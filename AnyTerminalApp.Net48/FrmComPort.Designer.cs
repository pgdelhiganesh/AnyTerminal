namespace AnyTerminalApp.Net48
{
  partial class FrmComPort
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComPort));
      this.btnOpen = new System.Windows.Forms.Button();
      this.cbFlowControl = new System.Windows.Forms.ComboBox();
      this.cbStopBit = new System.Windows.Forms.ComboBox();
      this.cbParityBit = new System.Windows.Forms.ComboBox();
      this.cbDataBit = new System.Windows.Forms.ComboBox();
      this.cbBaudRate = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cbCOMport = new System.Windows.Forms.ComboBox();
      this.PicBoxAppImage = new System.Windows.Forms.PictureBox();
      this.LblAppVersion = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.btnSendTx = new System.Windows.Forms.Button();
      this.btnHexTx = new System.Windows.Forms.Button();
      this.btnClearTx = new System.Windows.Forms.Button();
      this.lblTxByteCount = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.lblRxByteCount = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.btnHexRx = new System.Windows.Forms.Button();
      this.btnClearRx = new System.Windows.Forms.Button();
      this.tlbDataContainer = new System.Windows.Forms.TableLayoutPanel();
      this.tlbDataRxContainer = new System.Windows.Forms.TableLayoutPanel();
      this.tbRx = new System.Windows.Forms.TextBox();
      this.tbRxHex = new System.Windows.Forms.TextBox();
      this.tbTx = new System.Windows.Forms.TextBox();
      this.pnlRxLabel = new System.Windows.Forms.Panel();
      this.pnlTxLabel = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.PicBoxAppImage)).BeginInit();
      this.tlbDataContainer.SuspendLayout();
      this.tlbDataRxContainer.SuspendLayout();
      this.pnlRxLabel.SuspendLayout();
      this.pnlTxLabel.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnOpen
      // 
      this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.btnOpen.Location = new System.Drawing.Point(584, 95);
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(85, 23);
      this.btnOpen.TabIndex = 25;
      this.btnOpen.Text = "Open";
      this.btnOpen.UseVisualStyleBackColor = true;
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // cbFlowControl
      // 
      this.cbFlowControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.cbFlowControl.FormattingEnabled = true;
      this.cbFlowControl.Items.AddRange(new object[] {
            "None",
            "RTS",
            "Hardware",
            "Xon/Xoff"});
      this.cbFlowControl.Location = new System.Drawing.Point(480, 97);
      this.cbFlowControl.Name = "cbFlowControl";
      this.cbFlowControl.Size = new System.Drawing.Size(85, 21);
      this.cbFlowControl.TabIndex = 24;
      this.cbFlowControl.SelectedIndexChanged += new System.EventHandler(this.cbFlowControl_SelectedIndexChanged);
      // 
      // cbStopBit
      // 
      this.cbStopBit.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.cbStopBit.FormattingEnabled = true;
      this.cbStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "None"});
      this.cbStopBit.Location = new System.Drawing.Point(389, 97);
      this.cbStopBit.Name = "cbStopBit";
      this.cbStopBit.Size = new System.Drawing.Size(85, 21);
      this.cbStopBit.TabIndex = 23;
      this.cbStopBit.SelectedIndexChanged += new System.EventHandler(this.cbStopBit_SelectedIndexChanged);
      // 
      // cbParityBit
      // 
      this.cbParityBit.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.cbParityBit.FormattingEnabled = true;
      this.cbParityBit.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
      this.cbParityBit.Location = new System.Drawing.Point(298, 97);
      this.cbParityBit.Name = "cbParityBit";
      this.cbParityBit.Size = new System.Drawing.Size(85, 21);
      this.cbParityBit.TabIndex = 22;
      this.cbParityBit.SelectedIndexChanged += new System.EventHandler(this.cbParityBit_SelectedIndexChanged);
      // 
      // cbDataBit
      // 
      this.cbDataBit.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.cbDataBit.FormattingEnabled = true;
      this.cbDataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5",
            "4"});
      this.cbDataBit.Location = new System.Drawing.Point(207, 97);
      this.cbDataBit.Name = "cbDataBit";
      this.cbDataBit.Size = new System.Drawing.Size(85, 21);
      this.cbDataBit.TabIndex = 21;
      this.cbDataBit.SelectedIndexChanged += new System.EventHandler(this.cbDataBit_SelectedIndexChanged);
      // 
      // cbBaudRate
      // 
      this.cbBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.cbBaudRate.FormattingEnabled = true;
      this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
      this.cbBaudRate.Location = new System.Drawing.Point(116, 97);
      this.cbBaudRate.Name = "cbBaudRate";
      this.cbBaudRate.Size = new System.Drawing.Size(85, 21);
      this.cbBaudRate.TabIndex = 20;
      this.cbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbBaudRate_SelectedIndexChanged);
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(477, 81);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(65, 13);
      this.label6.TabIndex = 19;
      this.label6.Text = "Flow Control";
      // 
      // label5
      // 
      this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(386, 81);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(44, 13);
      this.label5.TabIndex = 18;
      this.label5.Text = "Stop Bit";
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(295, 81);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 13);
      this.label4.TabIndex = 17;
      this.label4.Text = "Parity Bit";
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(204, 81);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 13);
      this.label3.TabIndex = 16;
      this.label3.Text = "Data Bit";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(113, 81);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 13);
      this.label2.TabIndex = 15;
      this.label2.Text = "Baud Rate";
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 81);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(85, 13);
      this.label1.TabIndex = 14;
      this.label1.Text = "Select COM port";
      // 
      // cbCOMport
      // 
      this.cbCOMport.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.cbCOMport.FormattingEnabled = true;
      this.cbCOMport.Location = new System.Drawing.Point(15, 97);
      this.cbCOMport.Name = "cbCOMport";
      this.cbCOMport.Size = new System.Drawing.Size(95, 21);
      this.cbCOMport.TabIndex = 13;
      this.cbCOMport.DropDown += new System.EventHandler(this.cbCOMport_DropDown);
      this.cbCOMport.SelectedIndexChanged += new System.EventHandler(this.cbCOMport_SelectedIndexChanged);
      // 
      // PicBoxAppImage
      // 
      this.PicBoxAppImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.PicBoxAppImage.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxAppImage.Image")));
      this.PicBoxAppImage.Location = new System.Drawing.Point(519, 12);
      this.PicBoxAppImage.Name = "PicBoxAppImage";
      this.PicBoxAppImage.Size = new System.Drawing.Size(150, 50);
      this.PicBoxAppImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.PicBoxAppImage.TabIndex = 26;
      this.PicBoxAppImage.TabStop = false;
      // 
      // LblAppVersion
      // 
      this.LblAppVersion.AutoSize = true;
      this.LblAppVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LblAppVersion.Location = new System.Drawing.Point(12, 43);
      this.LblAppVersion.Name = "LblAppVersion";
      this.LblAppVersion.Size = new System.Drawing.Size(78, 16);
      this.LblAppVersion.TabIndex = 27;
      this.LblAppVersion.Text = "AppVersion";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(12, 15);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(176, 20);
      this.label7.TabIndex = 28;
      this.label7.Text = "Serial RS232 COM Port";
      // 
      // btnSendTx
      // 
      this.btnSendTx.Location = new System.Drawing.Point(3, 94);
      this.btnSendTx.Name = "btnSendTx";
      this.btnSendTx.Size = new System.Drawing.Size(55, 23);
      this.btnSendTx.TabIndex = 40;
      this.btnSendTx.Text = "Send";
      this.btnSendTx.UseVisualStyleBackColor = true;
      this.btnSendTx.Click += new System.EventHandler(this.btnSendTx_Click);
      // 
      // btnHexTx
      // 
      this.btnHexTx.Location = new System.Drawing.Point(3, 30);
      this.btnHexTx.Name = "btnHexTx";
      this.btnHexTx.Size = new System.Drawing.Size(55, 23);
      this.btnHexTx.TabIndex = 39;
      this.btnHexTx.Text = "Hex";
      this.btnHexTx.UseVisualStyleBackColor = true;
      this.btnHexTx.Click += new System.EventHandler(this.btnHexTx_Click);
      // 
      // btnClearTx
      // 
      this.btnClearTx.Location = new System.Drawing.Point(3, 3);
      this.btnClearTx.Name = "btnClearTx";
      this.btnClearTx.Size = new System.Drawing.Size(55, 23);
      this.btnClearTx.TabIndex = 38;
      this.btnClearTx.Text = "Clear";
      this.btnClearTx.UseVisualStyleBackColor = true;
      this.btnClearTx.Click += new System.EventHandler(this.btnClearTx_Click);
      // 
      // lblTxByteCount
      // 
      this.lblTxByteCount.AutoSize = true;
      this.lblTxByteCount.Location = new System.Drawing.Point(3, 78);
      this.lblTxByteCount.Name = "lblTxByteCount";
      this.lblTxByteCount.Size = new System.Drawing.Size(13, 13);
      this.lblTxByteCount.TabIndex = 37;
      this.lblTxByteCount.Text = "0";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(3, 56);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(59, 13);
      this.label9.TabIndex = 36;
      this.label9.Text = "Byte Count";
      // 
      // lblRxByteCount
      // 
      this.lblRxByteCount.AutoSize = true;
      this.lblRxByteCount.Location = new System.Drawing.Point(3, 92);
      this.lblRxByteCount.Name = "lblRxByteCount";
      this.lblRxByteCount.Size = new System.Drawing.Size(13, 13);
      this.lblRxByteCount.TabIndex = 34;
      this.lblRxByteCount.Text = "0";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(3, 70);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(59, 13);
      this.label8.TabIndex = 33;
      this.label8.Text = "Byte Count";
      // 
      // btnHexRx
      // 
      this.btnHexRx.Location = new System.Drawing.Point(3, 32);
      this.btnHexRx.Name = "btnHexRx";
      this.btnHexRx.Size = new System.Drawing.Size(55, 23);
      this.btnHexRx.TabIndex = 31;
      this.btnHexRx.Text = "Hex";
      this.btnHexRx.UseVisualStyleBackColor = true;
      this.btnHexRx.Click += new System.EventHandler(this.btnHexRx_Click);
      // 
      // btnClearRx
      // 
      this.btnClearRx.Location = new System.Drawing.Point(3, 3);
      this.btnClearRx.Name = "btnClearRx";
      this.btnClearRx.Size = new System.Drawing.Size(55, 23);
      this.btnClearRx.TabIndex = 30;
      this.btnClearRx.Text = "Clear";
      this.btnClearRx.UseVisualStyleBackColor = true;
      this.btnClearRx.Click += new System.EventHandler(this.btnClearRx_Click);
      // 
      // tlbDataContainer
      // 
      this.tlbDataContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tlbDataContainer.ColumnCount = 2;
      this.tlbDataContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.tlbDataContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tlbDataContainer.Controls.Add(this.pnlTxLabel, 0, 1);
      this.tlbDataContainer.Controls.Add(this.pnlRxLabel, 0, 0);
      this.tlbDataContainer.Controls.Add(this.tbTx, 1, 1);
      this.tlbDataContainer.Controls.Add(this.tlbDataRxContainer, 1, 0);
      this.tlbDataContainer.Location = new System.Drawing.Point(16, 133);
      this.tlbDataContainer.Name = "tlbDataContainer";
      this.tlbDataContainer.RowCount = 2;
      this.tlbDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
      this.tlbDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this.tlbDataContainer.Size = new System.Drawing.Size(653, 316);
      this.tlbDataContainer.TabIndex = 41;
      // 
      // tlbDataRxContainer
      // 
      this.tlbDataRxContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tlbDataRxContainer.ColumnCount = 2;
      this.tlbDataRxContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tlbDataRxContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tlbDataRxContainer.Controls.Add(this.tbRxHex, 1, 0);
      this.tlbDataRxContainer.Controls.Add(this.tbRx, 0, 0);
      this.tlbDataRxContainer.Location = new System.Drawing.Point(73, 3);
      this.tlbDataRxContainer.Name = "tlbDataRxContainer";
      this.tlbDataRxContainer.RowCount = 1;
      this.tlbDataRxContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlbDataRxContainer.Size = new System.Drawing.Size(577, 183);
      this.tlbDataRxContainer.TabIndex = 0;
      // 
      // tbRx
      // 
      this.tbRx.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbRx.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbRx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.tbRx.Location = new System.Drawing.Point(3, 3);
      this.tbRx.Multiline = true;
      this.tbRx.Name = "tbRx";
      this.tbRx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.tbRx.Size = new System.Drawing.Size(278, 177);
      this.tbRx.TabIndex = 30;
      // 
      // tbRxHex
      // 
      this.tbRxHex.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbRxHex.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbRxHex.ForeColor = System.Drawing.Color.Blue;
      this.tbRxHex.Location = new System.Drawing.Point(287, 3);
      this.tbRxHex.Multiline = true;
      this.tbRxHex.Name = "tbRxHex";
      this.tbRxHex.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.tbRxHex.Size = new System.Drawing.Size(298, 177);
      this.tbRxHex.TabIndex = 33;
      // 
      // tbTx
      // 
      this.tbTx.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbTx.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbTx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tbTx.Location = new System.Drawing.Point(73, 192);
      this.tbTx.Multiline = true;
      this.tbTx.Name = "tbTx";
      this.tbTx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.tbTx.Size = new System.Drawing.Size(577, 121);
      this.tbTx.TabIndex = 36;
      // 
      // pnlRxLabel
      // 
      this.pnlRxLabel.Controls.Add(this.btnClearRx);
      this.pnlRxLabel.Controls.Add(this.btnHexRx);
      this.pnlRxLabel.Controls.Add(this.label8);
      this.pnlRxLabel.Controls.Add(this.lblRxByteCount);
      this.pnlRxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlRxLabel.Location = new System.Drawing.Point(3, 3);
      this.pnlRxLabel.Name = "pnlRxLabel";
      this.pnlRxLabel.Size = new System.Drawing.Size(64, 183);
      this.pnlRxLabel.TabIndex = 42;
      // 
      // pnlTxLabel
      // 
      this.pnlTxLabel.Controls.Add(this.btnClearTx);
      this.pnlTxLabel.Controls.Add(this.btnSendTx);
      this.pnlTxLabel.Controls.Add(this.label9);
      this.pnlTxLabel.Controls.Add(this.btnHexTx);
      this.pnlTxLabel.Controls.Add(this.lblTxByteCount);
      this.pnlTxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlTxLabel.Location = new System.Drawing.Point(3, 192);
      this.pnlTxLabel.Name = "pnlTxLabel";
      this.pnlTxLabel.Size = new System.Drawing.Size(64, 121);
      this.pnlTxLabel.TabIndex = 43;
      // 
      // FrmComPort
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(684, 461);
      this.Controls.Add(this.tlbDataContainer);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.LblAppVersion);
      this.Controls.Add(this.PicBoxAppImage);
      this.Controls.Add(this.btnOpen);
      this.Controls.Add(this.cbFlowControl);
      this.Controls.Add(this.cbStopBit);
      this.Controls.Add(this.cbParityBit);
      this.Controls.Add(this.cbDataBit);
      this.Controls.Add(this.cbBaudRate);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbCOMport);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmComPort";
      this.Text = "Serial RS232 COM Port";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmComPort_FormClosing);
      this.Load += new System.EventHandler(this.FrmComPort_Load);
      ((System.ComponentModel.ISupportInitialize)(this.PicBoxAppImage)).EndInit();
      this.tlbDataContainer.ResumeLayout(false);
      this.tlbDataContainer.PerformLayout();
      this.tlbDataRxContainer.ResumeLayout(false);
      this.tlbDataRxContainer.PerformLayout();
      this.pnlRxLabel.ResumeLayout(false);
      this.pnlRxLabel.PerformLayout();
      this.pnlTxLabel.ResumeLayout(false);
      this.pnlTxLabel.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOpen;
    private System.Windows.Forms.ComboBox cbFlowControl;
    private System.Windows.Forms.ComboBox cbStopBit;
    private System.Windows.Forms.ComboBox cbParityBit;
    private System.Windows.Forms.ComboBox cbDataBit;
    private System.Windows.Forms.ComboBox cbBaudRate;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbCOMport;
    private System.Windows.Forms.PictureBox PicBoxAppImage;
    private System.Windows.Forms.Label LblAppVersion;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnSendTx;
    private System.Windows.Forms.Button btnHexTx;
    private System.Windows.Forms.Button btnClearTx;
    private System.Windows.Forms.Label lblTxByteCount;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblRxByteCount;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button btnHexRx;
    private System.Windows.Forms.Button btnClearRx;
    private System.Windows.Forms.TableLayoutPanel tlbDataContainer;
    private System.Windows.Forms.TableLayoutPanel tlbDataRxContainer;
    private System.Windows.Forms.TextBox tbRxHex;
    private System.Windows.Forms.TextBox tbRx;
    private System.Windows.Forms.TextBox tbTx;
    private System.Windows.Forms.Panel pnlTxLabel;
    private System.Windows.Forms.Panel pnlRxLabel;
  }
}