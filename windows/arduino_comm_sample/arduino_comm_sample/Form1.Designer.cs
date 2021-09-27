namespace arduino_comm_sample
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnScan = new System.Windows.Forms.Button();
            this.cmbCOMPort = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.radiobtnLED0On = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chkboxAutoSend = new System.Windows.Forms.CheckBox();
            this.radiobtnLED0Off = new System.Windows.Forms.RadioButton();
            this.groupboxLED0 = new System.Windows.Forms.GroupBox();
            this.groupboxLED1 = new System.Windows.Forms.GroupBox();
            this.radiobtnLED1On = new System.Windows.Forms.RadioButton();
            this.radiobtnLED1Off = new System.Windows.Forms.RadioButton();
            this.groupboxLED2 = new System.Windows.Forms.GroupBox();
            this.radiobtnLED2On = new System.Windows.Forms.RadioButton();
            this.radiobtnLED2Off = new System.Windows.Forms.RadioButton();
            this.groupboxLED0.SuspendLayout();
            this.groupboxLED1.SuspendLayout();
            this.groupboxLED2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(12, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(120, 32);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "再スキャン";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cmbCOMPort
            // 
            this.cmbCOMPort.FormattingEnabled = true;
            this.cmbCOMPort.Location = new System.Drawing.Point(138, 16);
            this.cmbCOMPort.Name = "cmbCOMPort";
            this.cmbCOMPort.Size = new System.Drawing.Size(160, 26);
            this.cmbCOMPort.TabIndex = 1;
            this.cmbCOMPort.Text = "選択してください";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(304, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(80, 32);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "接続";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(390, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "切断";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(304, 58);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 32);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "送信";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // radiobtnLED0On
            // 
            this.radiobtnLED0On.AutoSize = true;
            this.radiobtnLED0On.Checked = true;
            this.radiobtnLED0On.Location = new System.Drawing.Point(6, 24);
            this.radiobtnLED0On.Name = "radiobtnLED0On";
            this.radiobtnLED0On.Size = new System.Drawing.Size(58, 22);
            this.radiobtnLED0On.TabIndex = 5;
            this.radiobtnLED0On.TabStop = true;
            this.radiobtnLED0On.Text = "ON";
            this.radiobtnLED0On.UseVisualStyleBackColor = true;
            this.radiobtnLED0On.CheckedChanged += new System.EventHandler(this.radiobtnLED0On_CheckedChanged);
            // 
            // chkboxAutoSend
            // 
            this.chkboxAutoSend.AutoSize = true;
            this.chkboxAutoSend.Checked = true;
            this.chkboxAutoSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxAutoSend.Location = new System.Drawing.Point(304, 110);
            this.chkboxAutoSend.Name = "chkboxAutoSend";
            this.chkboxAutoSend.Size = new System.Drawing.Size(106, 22);
            this.chkboxAutoSend.TabIndex = 6;
            this.chkboxAutoSend.Text = "自動送信";
            this.chkboxAutoSend.UseVisualStyleBackColor = true;
            this.chkboxAutoSend.CheckedChanged += new System.EventHandler(this.chkboxAutoSend_CheckedChanged);
            // 
            // radiobtnLED0Off
            // 
            this.radiobtnLED0Off.AutoSize = true;
            this.radiobtnLED0Off.Location = new System.Drawing.Point(6, 52);
            this.radiobtnLED0Off.Name = "radiobtnLED0Off";
            this.radiobtnLED0Off.Size = new System.Drawing.Size(66, 22);
            this.radiobtnLED0Off.TabIndex = 7;
            this.radiobtnLED0Off.Text = "OFF";
            this.radiobtnLED0Off.UseVisualStyleBackColor = true;
            this.radiobtnLED0Off.CheckedChanged += new System.EventHandler(this.radiobtnLED0Off_CheckedChanged);
            // 
            // groupboxLED0
            // 
            this.groupboxLED0.Controls.Add(this.radiobtnLED0On);
            this.groupboxLED0.Controls.Add(this.radiobtnLED0Off);
            this.groupboxLED0.Location = new System.Drawing.Point(12, 58);
            this.groupboxLED0.Name = "groupboxLED0";
            this.groupboxLED0.Size = new System.Drawing.Size(80, 100);
            this.groupboxLED0.TabIndex = 8;
            this.groupboxLED0.TabStop = false;
            this.groupboxLED0.Text = "LED0";
            // 
            // groupboxLED1
            // 
            this.groupboxLED1.Controls.Add(this.radiobtnLED1On);
            this.groupboxLED1.Controls.Add(this.radiobtnLED1Off);
            this.groupboxLED1.Location = new System.Drawing.Point(98, 58);
            this.groupboxLED1.Name = "groupboxLED1";
            this.groupboxLED1.Size = new System.Drawing.Size(80, 100);
            this.groupboxLED1.TabIndex = 9;
            this.groupboxLED1.TabStop = false;
            this.groupboxLED1.Text = "LED1";
            // 
            // radiobtnLED1On
            // 
            this.radiobtnLED1On.AutoSize = true;
            this.radiobtnLED1On.Checked = true;
            this.radiobtnLED1On.Location = new System.Drawing.Point(6, 24);
            this.radiobtnLED1On.Name = "radiobtnLED1On";
            this.radiobtnLED1On.Size = new System.Drawing.Size(58, 22);
            this.radiobtnLED1On.TabIndex = 5;
            this.radiobtnLED1On.TabStop = true;
            this.radiobtnLED1On.Text = "ON";
            this.radiobtnLED1On.UseVisualStyleBackColor = true;
            this.radiobtnLED1On.CheckedChanged += new System.EventHandler(this.radiobtnLED1On_CheckedChanged);
            // 
            // radiobtnLED1Off
            // 
            this.radiobtnLED1Off.AutoSize = true;
            this.radiobtnLED1Off.Location = new System.Drawing.Point(6, 52);
            this.radiobtnLED1Off.Name = "radiobtnLED1Off";
            this.radiobtnLED1Off.Size = new System.Drawing.Size(66, 22);
            this.radiobtnLED1Off.TabIndex = 7;
            this.radiobtnLED1Off.Text = "OFF";
            this.radiobtnLED1Off.UseVisualStyleBackColor = true;
            this.radiobtnLED1Off.CheckedChanged += new System.EventHandler(this.radiobtnLED1Off_CheckedChanged);
            // 
            // groupboxLED2
            // 
            this.groupboxLED2.Controls.Add(this.radiobtnLED2On);
            this.groupboxLED2.Controls.Add(this.radiobtnLED2Off);
            this.groupboxLED2.Location = new System.Drawing.Point(184, 58);
            this.groupboxLED2.Name = "groupboxLED2";
            this.groupboxLED2.Size = new System.Drawing.Size(80, 100);
            this.groupboxLED2.TabIndex = 11;
            this.groupboxLED2.TabStop = false;
            this.groupboxLED2.Text = "LED2";
            // 
            // radiobtnLED2On
            // 
            this.radiobtnLED2On.AutoSize = true;
            this.radiobtnLED2On.Checked = true;
            this.radiobtnLED2On.Location = new System.Drawing.Point(6, 24);
            this.radiobtnLED2On.Name = "radiobtnLED2On";
            this.radiobtnLED2On.Size = new System.Drawing.Size(58, 22);
            this.radiobtnLED2On.TabIndex = 5;
            this.radiobtnLED2On.TabStop = true;
            this.radiobtnLED2On.Text = "ON";
            this.radiobtnLED2On.UseVisualStyleBackColor = true;
            this.radiobtnLED2On.CheckedChanged += new System.EventHandler(this.radiobtnLED2On_CheckedChanged);
            // 
            // radiobtnLED2Off
            // 
            this.radiobtnLED2Off.AutoSize = true;
            this.radiobtnLED2Off.Location = new System.Drawing.Point(6, 52);
            this.radiobtnLED2Off.Name = "radiobtnLED2Off";
            this.radiobtnLED2Off.Size = new System.Drawing.Size(66, 22);
            this.radiobtnLED2Off.TabIndex = 7;
            this.radiobtnLED2Off.Text = "OFF";
            this.radiobtnLED2Off.UseVisualStyleBackColor = true;
            this.radiobtnLED2Off.CheckedChanged += new System.EventHandler(this.radiobtnLED2Off_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 169);
            this.Controls.Add(this.groupboxLED2);
            this.Controls.Add(this.groupboxLED1);
            this.Controls.Add(this.groupboxLED0);
            this.Controls.Add(this.chkboxAutoSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cmbCOMPort);
            this.Controls.Add(this.btnScan);
            this.Name = "Main";
            this.Text = "Arduino Controller";
            this.groupboxLED0.ResumeLayout(false);
            this.groupboxLED0.PerformLayout();
            this.groupboxLED1.ResumeLayout(false);
            this.groupboxLED1.PerformLayout();
            this.groupboxLED2.ResumeLayout(false);
            this.groupboxLED2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox cmbCOMPort;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton radiobtnLED0On;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chkboxAutoSend;
        private System.Windows.Forms.RadioButton radiobtnLED0Off;
        private System.Windows.Forms.GroupBox groupboxLED0;
        private System.Windows.Forms.GroupBox groupboxLED1;
        private System.Windows.Forms.RadioButton radiobtnLED1On;
        private System.Windows.Forms.RadioButton radiobtnLED1Off;
        private System.Windows.Forms.GroupBox groupboxLED2;
        private System.Windows.Forms.RadioButton radiobtnLED2On;
        private System.Windows.Forms.RadioButton radiobtnLED2Off;
    }
}

