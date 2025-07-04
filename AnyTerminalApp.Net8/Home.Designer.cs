namespace AnyTerminalApp.Net8
{
  partial class Home
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
      LblAppVersion = new Label();
      BtnComPort = new Button();
      PicBoxAppImage = new PictureBox();
      BtnTcpClientPort = new Button();
      BtnTcpServerPort = new Button();
      ((System.ComponentModel.ISupportInitialize)PicBoxAppImage).BeginInit();
      SuspendLayout();
      // 
      // LblAppVersion
      // 
      LblAppVersion.AutoSize = true;
      LblAppVersion.Font = new Font("Microsoft Sans Serif", 9.75F);
      LblAppVersion.Location = new Point(12, 185);
      LblAppVersion.Name = "LblAppVersion";
      LblAppVersion.Size = new Size(78, 16);
      LblAppVersion.TabIndex = 0;
      LblAppVersion.Text = "AppVersion";
      // 
      // BtnComPort
      // 
      BtnComPort.Font = new Font("Microsoft Sans Serif", 9.75F);
      BtnComPort.Location = new Point(34, 102);
      BtnComPort.Name = "BtnComPort";
      BtnComPort.Size = new Size(108, 50);
      BtnComPort.TabIndex = 1;
      BtnComPort.Text = "Serial RS232 COM Port";
      BtnComPort.UseVisualStyleBackColor = true;
      BtnComPort.Click += BtnComPort_Click;
      // 
      // PicBoxAppImage
      // 
      PicBoxAppImage.Image = (Image)resources.GetObject("PicBoxAppImage.Image");
      PicBoxAppImage.Location = new Point(130, 12);
      PicBoxAppImage.Name = "PicBoxAppImage";
      PicBoxAppImage.Size = new Size(180, 60);
      PicBoxAppImage.SizeMode = PictureBoxSizeMode.Zoom;
      PicBoxAppImage.TabIndex = 2;
      PicBoxAppImage.TabStop = false;
      // 
      // BtnTcpClientPort
      // 
      BtnTcpClientPort.Font = new Font("Microsoft Sans Serif", 9.75F);
      BtnTcpClientPort.Location = new Point(167, 102);
      BtnTcpClientPort.Name = "BtnTcpClientPort";
      BtnTcpClientPort.Size = new Size(108, 50);
      BtnTcpClientPort.TabIndex = 3;
      BtnTcpClientPort.Text = "Ethernet TCP/IP Client";
      BtnTcpClientPort.UseVisualStyleBackColor = true;
      BtnTcpClientPort.Click += BtnTcpClientPort_Click;
      // 
      // BtnTcpServerPort
      // 
      BtnTcpServerPort.Font = new Font("Microsoft Sans Serif", 9.75F);
      BtnTcpServerPort.Location = new Point(300, 102);
      BtnTcpServerPort.Name = "BtnTcpServerPort";
      BtnTcpServerPort.Size = new Size(108, 50);
      BtnTcpServerPort.TabIndex = 4;
      BtnTcpServerPort.Text = "Ethernet TCP/IP Server";
      BtnTcpServerPort.UseVisualStyleBackColor = true;
      BtnTcpServerPort.Click += BtnTcpServerPort_Click;
      // 
      // Home
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(434, 211);
      Controls.Add(BtnTcpServerPort);
      Controls.Add(BtnTcpClientPort);
      Controls.Add(PicBoxAppImage);
      Controls.Add(BtnComPort);
      Controls.Add(LblAppVersion);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "Home";
      Text = "AppName";
      Load += Form1_Load;
      ((System.ComponentModel.ISupportInitialize)PicBoxAppImage).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label LblAppVersion;
    private Button BtnComPort;
    private PictureBox PicBoxAppImage;
    private Button BtnTcpClientPort;
    private Button BtnTcpServerPort;
  }
}