namespace AnyTerminalApp.Net472
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
      this.LblAppVersion = new System.Windows.Forms.Label();
      this.BtnComPort = new System.Windows.Forms.Button();
      this.PicBoxAppImage = new System.Windows.Forms.PictureBox();
      this.BtnTcpClientPort = new System.Windows.Forms.Button();
      this.BtnTcpServerPort = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.PicBoxAppImage)).BeginInit();
      this.SuspendLayout();
      // 
      // LblAppVersion
      // 
      this.LblAppVersion.AutoSize = true;
      this.LblAppVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LblAppVersion.Location = new System.Drawing.Point(12, 182);
      this.LblAppVersion.Name = "LblAppVersion";
      this.LblAppVersion.Size = new System.Drawing.Size(78, 16);
      this.LblAppVersion.TabIndex = 1;
      this.LblAppVersion.Text = "AppVersion";
      // 
      // BtnComPort
      // 
      this.BtnComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnComPort.Location = new System.Drawing.Point(34, 101);
      this.BtnComPort.Name = "BtnComPort";
      this.BtnComPort.Size = new System.Drawing.Size(108, 50);
      this.BtnComPort.TabIndex = 2;
      this.BtnComPort.Text = "Serial RS232 COM Port";
      this.BtnComPort.UseVisualStyleBackColor = true;
      this.BtnComPort.Click += new System.EventHandler(this.BtnComPort_Click);
      // 
      // PicBoxAppImage
      // 
      this.PicBoxAppImage.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxAppImage.Image")));
      this.PicBoxAppImage.Location = new System.Drawing.Point(130, 12);
      this.PicBoxAppImage.Name = "PicBoxAppImage";
      this.PicBoxAppImage.Size = new System.Drawing.Size(180, 60);
      this.PicBoxAppImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.PicBoxAppImage.TabIndex = 3;
      this.PicBoxAppImage.TabStop = false;
      // 
      // BtnTcpClientPort
      // 
      this.BtnTcpClientPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnTcpClientPort.Location = new System.Drawing.Point(166, 101);
      this.BtnTcpClientPort.Name = "BtnTcpClientPort";
      this.BtnTcpClientPort.Size = new System.Drawing.Size(108, 50);
      this.BtnTcpClientPort.TabIndex = 4;
      this.BtnTcpClientPort.Text = "Ethernet TCP/IP Client";
      this.BtnTcpClientPort.UseVisualStyleBackColor = true;
      this.BtnTcpClientPort.Click += new System.EventHandler(this.BtnTcpClientPort_Click);
      // 
      // BtnTcpServerPort
      // 
      this.BtnTcpServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnTcpServerPort.Location = new System.Drawing.Point(298, 101);
      this.BtnTcpServerPort.Name = "BtnTcpServerPort";
      this.BtnTcpServerPort.Size = new System.Drawing.Size(108, 50);
      this.BtnTcpServerPort.TabIndex = 5;
      this.BtnTcpServerPort.Text = "Ethernet TCP/IP Server";
      this.BtnTcpServerPort.UseVisualStyleBackColor = true;
      this.BtnTcpServerPort.Click += new System.EventHandler(this.BtnTcpServerPort_Click);
      // 
      // Home
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ClientSize = new System.Drawing.Size(434, 211);
      this.Controls.Add(this.BtnTcpServerPort);
      this.Controls.Add(this.BtnTcpClientPort);
      this.Controls.Add(this.PicBoxAppImage);
      this.Controls.Add(this.BtnComPort);
      this.Controls.Add(this.LblAppVersion);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Home";
      this.Text = "AppName";
      this.Load += new System.EventHandler(this.Home_Load);
      ((System.ComponentModel.ISupportInitialize)(this.PicBoxAppImage)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label LblAppVersion;
    private System.Windows.Forms.Button BtnComPort;
    private System.Windows.Forms.PictureBox PicBoxAppImage;
    private System.Windows.Forms.Button BtnTcpClientPort;
    private System.Windows.Forms.Button BtnTcpServerPort;
  }
}

