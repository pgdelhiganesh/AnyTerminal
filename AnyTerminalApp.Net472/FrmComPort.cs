using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace AnyTerminalApp.Net472
{
  public partial class FrmComPort : Form
  {
    public FrmComPort()
    {
      InitializeComponent();

      Form.CheckForIllegalCrossThreadCalls = false;
      TextBox.CheckForIllegalCrossThreadCalls = false;
    }


    string tx_data_text = "";
    string tx_data_text_hex = "";
    bool tx_data_text_hex_enabled = false;

    string rx_data_text = "";
    string rx_data_text_hex = "";
    bool rx_data_text_hex_enabled = false;

    SerialPort _userSerialPort = new SerialPort();
    bool port_opened = false;

    string Selected_COM_Port; //to store selected COM port number as a string
    string Selected_COM_Port_Baudrate = "9600"; //to store selected baud rate as  a string
    string Selected_COM_Port_Databits = "8"; //to store selected data bits as  a string
    string Selected_COM_Port_Paritybits = "None"; //to store selected parity bits as  a string
    string Selected_COM_Port_Stopbits = "One"; //to store selected stop bits as  a string
    string Selected_COM_Port_Flowcontrol = "None"; //to store selected stop bits as  a string

    Thread thread;

    private void FrmComPort_Load(object sender, EventArgs e)
    {
      LblAppVersion.Text = $"Version {AppInfo.ReleaseVersion} ({AppInfo.ReleaseDate})";

      cbBaudRate.SelectedIndex = 3;
      cbDataBit.SelectedIndex = 0;
      cbParityBit.SelectedIndex = 0;
      cbStopBit.SelectedIndex = 0; 
      cbFlowControl.SelectedIndex = 0;

      // Collapse second column
      tlbDataRxContainer.ColumnStyles[1].SizeType = SizeType.Absolute;
      tlbDataRxContainer.ColumnStyles[1].Width = 0;

      // Expand first column
      tlbDataRxContainer.ColumnStyles[0].SizeType = SizeType.Percent;
      tlbDataRxContainer.ColumnStyles[0].Width = 100;
    }
    private void FrmComPort_FormClosing(object sender, FormClosingEventArgs e)
    {
      port_opened = false;
      _userSerialPort.Close();
      //MessageBox.Show("Unfortunatly Port Closed.", "Error!");
      btnOpen.Text = "Open";
      btnOpen.BackColor = SystemColors.Control;
      if (thread != null)
      {
        thread.Abort();
      }
    }

    private void cbCOMport_DropDown(object sender, EventArgs e)
    {
      //Populate the Combobox with SerialPorts on the System
      cbCOMport.Items.Clear();
      cbCOMport.Items.AddRange(SerialPort.GetPortNames());
    }

    private void cbCOMport_SelectedIndexChanged(object sender, EventArgs e)
    {
      Selected_COM_Port = cbCOMport.SelectedItem.ToString(); // Store the Selected COM port
    }

    private void cbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
    {
      Selected_COM_Port_Baudrate = cbBaudRate.SelectedItem.ToString();
    }

    private void cbDataBit_SelectedIndexChanged(object sender, EventArgs e)
    {
      Selected_COM_Port_Baudrate = cbBaudRate.SelectedItem.ToString();
    }

    private void cbParityBit_SelectedIndexChanged(object sender, EventArgs e)
    {
      Selected_COM_Port_Paritybits = cbDataBit.SelectedItem.ToString();
    }

    private void cbStopBit_SelectedIndexChanged(object sender, EventArgs e)
    {
      Selected_COM_Port_Stopbits = cbStopBit.SelectedItem.ToString();
    }

    private void cbFlowControl_SelectedIndexChanged(object sender, EventArgs e)
    {
      Selected_COM_Port_Flowcontrol = cbFlowControl.SelectedItem.ToString();
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
      if (Selected_COM_Port == null)
      {
        if (cbCOMport.Text.Trim().Length > 0)
        {
          Selected_COM_Port = cbCOMport.Text.Trim();
        }
        else
        {
          cbCOMport.DroppedDown = true;
        }
      }
      else if (port_opened == false)
      {
        if (thread != null)
        {
          thread.Abort();
        }

        _userSerialPort.PortName = Selected_COM_Port;

        _userSerialPort.BaudRate = Convert.ToInt32(Selected_COM_Port_Baudrate);

        _userSerialPort.DataBits = Convert.ToInt32(Selected_COM_Port_Databits);

        if (Selected_COM_Port_Paritybits == "None")
        { _userSerialPort.Parity = Parity.None; }
        else if (Selected_COM_Port_Paritybits == "Even")
        { _userSerialPort.Parity = Parity.Even; }
        else if (Selected_COM_Port_Paritybits == "Odd")
        { _userSerialPort.Parity = Parity.Odd; }
        else if (Selected_COM_Port_Paritybits == "Mark")
        { _userSerialPort.Parity = Parity.Mark; }
        else if (Selected_COM_Port_Paritybits == "Space")
        { _userSerialPort.Parity = Parity.Space; }

        if (Selected_COM_Port_Stopbits == "1")
        { _userSerialPort.StopBits = StopBits.One; }
        else if (Selected_COM_Port_Stopbits == "1.5")
        { _userSerialPort.StopBits = StopBits.OnePointFive; }
        else if (Selected_COM_Port_Stopbits == "2")
        { _userSerialPort.StopBits = StopBits.Two; }
        else if (Selected_COM_Port_Stopbits == "None")
        { _userSerialPort.StopBits = StopBits.None; }

        if (Selected_COM_Port_Flowcontrol == "None")
        { _userSerialPort.Handshake = Handshake.None; }
        else if (Selected_COM_Port_Flowcontrol == "RTS")
        { _userSerialPort.Handshake = Handshake.RequestToSend; }
        else if (Selected_COM_Port_Flowcontrol == "Hardware")
        { _userSerialPort.Handshake = Handshake.RequestToSendXOnXOff; }
        else if (Selected_COM_Port_Flowcontrol == "Xon/Xoff")
        { _userSerialPort.Handshake = Handshake.XOnXOff; }

        _userSerialPort.Close();
        port_opened = false;
        try
        {
          if (!(_userSerialPort.IsOpen))
          {
            _userSerialPort.Open();
            port_opened = true;
            //SerialDataReceivedEventHandler SerialPortDataReceived = null;
            //_userSerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            //_userSerialPort.DataReceived += SerialPortDataReceived;

            thread = new Thread(DataReceiveInSeperateThread);
            btnOpen.Text = "Close";
            btnOpen.BackColor = Color.OrangeRed;
            thread.Start();
          }
          else
          {
            _userSerialPort.Close();
            port_opened = false;
            btnOpen.Text = "Open";
            btnOpen.BackColor = SystemColors.Control;
          }
        }
        catch (Exception ex)
        {
          port_opened = false;
          _userSerialPort.Close();
          MessageBox.Show("Error opening serial port..." + ex.Message, "Error!");
          btnOpen.Text = "Open";
          btnOpen.BackColor = SystemColors.Control;
          if (thread != null)
          {
            thread.Abort();
          }
        }
      }
      else
      {
        _userSerialPort.Close();
        port_opened = false;
        btnOpen.Text = "Open";
        btnOpen.BackColor = SystemColors.Control;
        if (thread != null)
        {
          thread.Abort();
        }
      }
    }


    /*private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
{
    SerialPort sp = (SerialPort)sender;
    indata = sp.ReadExisting();
    rx_data_richtext_box.Text = rx_data_richtext_box.Text + data;
}
*/
    private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      try
      {
        var serialPort = (SerialPort)sender;
        var data = serialPort.ReadExisting();
        rx_data_text = rx_data_text + data;
        tbRx.Text = rx_data_text;
        rx_data_text_hex = ConvertStringToHex(data);
        var idx = data.IndexOf("\n"); // Returns -1 if not found
        if (idx >= 0)
        {
          tbRxHex.Text = tbRxHex.Text + Environment.NewLine + rx_data_text_hex;
        }
        else
        {
          tbRxHex.Text = tbRxHex.Text + rx_data_text_hex;
        }
        rx_data_text_hex = ConvertStringToHex(rx_data_text);
        lblRxByteCount.Text = Convert.ToString(rx_data_text.Length);
      }
      catch
      { }
    }

    private void DataReceiveInSeperateThread()
    {
      while (port_opened)
      {
        try
        {
          var data = _userSerialPort.ReadExisting();
          rx_data_text = rx_data_text + data;
          tbRx.Text = rx_data_text;
          rx_data_text_hex = ConvertStringToHex(data);
          var idx = data.IndexOf("\n"); // Returns -1 if not found
          if (idx >= 0)
          {
            tbRxHex.Text = tbRxHex.Text + Environment.NewLine + rx_data_text_hex;
          }
          else
          {
            tbRxHex.Text = tbRxHex.Text + rx_data_text_hex;
          }
          rx_data_text_hex = ConvertStringToHex(rx_data_text);
          lblRxByteCount.Text = Convert.ToString(rx_data_text.Length);
        }
        catch
        { port_opened = false; }
      }
      port_opened = false;
      _userSerialPort.Close();
      //MessageBox.Show("Unfortunatly Port Closed.", "Error!");
      btnOpen.Text = "Open";
      btnOpen.BackColor = SystemColors.Control;
      if (thread != null)
      {
        thread.Abort();
      }
    }

    private void btnClearRx_Click(object sender, EventArgs e)
    {
      rx_data_text = "";
      tbRx.Text = "";
      rx_data_text_hex = "";
      tbRxHex.Text = "";
      lblRxByteCount.Text = "0";
    }

    private void tbRx_TextChanged(object sender, EventArgs e)
    {
      tbRx.SelectionStart = tbRx.Text.Length;
      tbRx.ScrollToCaret();
      tbRx.Refresh();
    }

    private void btnHexRx_Click(object sender, EventArgs e)
    {
      if (rx_data_text_hex_enabled == false)
      {
        rx_data_text_hex_enabled = true;

        // Reset column widths
        tlbDataRxContainer.ColumnStyles[0].SizeType = SizeType.Percent;
        tlbDataRxContainer.ColumnStyles[0].Width = 50;

        tlbDataRxContainer.ColumnStyles[1].SizeType = SizeType.Percent;
        tlbDataRxContainer.ColumnStyles[1].Width = 50;
      }
      else
      {
        rx_data_text_hex_enabled = false;

        // Collapse second column
        tlbDataRxContainer.ColumnStyles[1].SizeType = SizeType.Absolute;
        tlbDataRxContainer.ColumnStyles[1].Width = 0;

        // Expand first column
        tlbDataRxContainer.ColumnStyles[0].SizeType = SizeType.Percent;
        tlbDataRxContainer.ColumnStyles[0].Width = 100;
      }
    }

    /*
    byte[] ba = Encoding.Default.GetBytes("sample"); //and then you can get the string:
    var hexString = BitConverter.ToString(ba); //now, that's going to return a string with dashes (-) in it so you can then simply use this:
    hexString = hexString.Replace("-", "");
    */
    public static string ConvertStringToHex(string asciiString)
    {
      string hex = "";
      foreach (char c in asciiString)
      {
        int tmp = c;
        hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
        hex += " ";
      }

      return hex;
    }

    public static string ConvertHexToString(string HexValue)
    {
      string StrValue = "";
      HexValue = HexValue.Replace(" ", "");
      while (HexValue.Length > 0)
      {
        StrValue += System.Convert.ToChar(System.Convert.ToUInt32(HexValue.Substring(0, 2), 16)).ToString();
        HexValue = HexValue.Substring(2, HexValue.Length - 2);
      }
      return StrValue;
    }

    private void tbRxHex_TextChanged(object sender, EventArgs e)
    {
      tbRxHex.SelectionStart = tbRxHex.Text.Length;
      tbRxHex.ScrollToCaret();
      tbRxHex.Refresh();
    }

    private void btnClearTx_Click(object sender, EventArgs e)
    {
      tx_data_text = "";
      tbTx.Text = "";
      tx_data_text_hex = "";
      lblTxByteCount.Text = "0";
    }

    private void tbTx_TextChanged(object sender, EventArgs e)
    {
      lblTxByteCount.Text = Convert.ToString(tbTx.Text.Length);
      tx_data_text = tbTx.Text.ToString();
    }

    private void btnHexTx_Click(object sender, EventArgs e)
    {
      if (tx_data_text_hex_enabled == false)
      {
        tx_data_text_hex_enabled = true;
        btnHexTx.Text = "ASCII";
        tx_data_text_hex = ConvertStringToHex(tbTx.Text.ToString());
        tbTx.Text = tx_data_text_hex;
      }
      else
      {
        tx_data_text_hex_enabled = false;
        btnHexTx.Text = "Hex";
        tbTx.Text = ConvertHexToString(tbTx.Text.ToString());
      }
    }

    private void btnSendTx_Click(object sender, EventArgs e)
    {
      if (tx_data_text_hex_enabled == true)
      {
        tx_data_text = ConvertHexToString(tbTx.Text.ToString());
      }
      else
      {
        tx_data_text = tbTx.Text.ToString();
      }

      if (_userSerialPort.IsOpen == true)
      {
        _userSerialPort.Write(tx_data_text);
        //string[] TextBoxLines = tbTx.Lines;
        //foreach (string line in TextBoxLines)
        //{
        //    _userSerialPort.WriteLine(line + "\r");
        //}
      }
      else
      {
        MessageBox.Show("Unable to Write to COM port ");
        _userSerialPort.Close();
      }
    }

  }
}
