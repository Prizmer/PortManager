namespace PortManager
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.rtbCmd = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAppendCRC = new System.Windows.Forms.Button();
            this.ctlConnectionSettings1 = new PollingLibraries.LibPorts.CtlConnectionSettings();
            this.ctlCrcCalc1 = new CRCCalc.CtlCrcCalc();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbLog.Location = new System.Drawing.Point(320, 43);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(518, 240);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.Text = "";
            this.rtbLog.DoubleClick += new System.EventHandler(this.rtbLog_DoubleClick);
            // 
            // rtbCmd
            // 
            this.rtbCmd.Font = new System.Drawing.Font("Arial", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbCmd.Location = new System.Drawing.Point(320, 306);
            this.rtbCmd.Name = "rtbCmd";
            this.rtbCmd.Size = new System.Drawing.Size(518, 66);
            this.rtbCmd.TabIndex = 3;
            this.rtbCmd.Text = "";
            this.rtbCmd.TextChanged += new System.EventHandler(this.rtbCmd_TextChanged);
            this.rtbCmd.DoubleClick += new System.EventHandler(this.rtbCmd_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Команда:";
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Location = new System.Drawing.Point(716, 378);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(122, 37);
            this.btnSendCmd.TabIndex = 5;
            this.btnSendCmd.Text = "Отправить";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Лог:";
            // 
            // btnAppendCRC
            // 
            this.btnAppendCRC.Location = new System.Drawing.Point(320, 378);
            this.btnAppendCRC.Name = "btnAppendCRC";
            this.btnAppendCRC.Size = new System.Drawing.Size(122, 37);
            this.btnAppendCRC.TabIndex = 8;
            this.btnAppendCRC.Text = "Дополнить CRC";
            this.btnAppendCRC.UseVisualStyleBackColor = true;
            this.btnAppendCRC.Click += new System.EventHandler(this.btnAppendCRC_Click);
            // 
            // ctlConnectionSettings1
            // 
            this.ctlConnectionSettings1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.ctlConnectionSettings1.COM = null;
            this.ctlConnectionSettings1.GSM = false;
            this.ctlConnectionSettings1.IP = null;
            this.ctlConnectionSettings1.IsTCPSelected = true;
            this.ctlConnectionSettings1.Location = new System.Drawing.Point(12, 9);
            this.ctlConnectionSettings1.Name = "ctlConnectionSettings1";
            this.ctlConnectionSettings1.Size = new System.Drawing.Size(292, 406);
            this.ctlConnectionSettings1.TabIndex = 9;
            this.ctlConnectionSettings1.TCPPort = "0";
            // 
            // ctlCrcCalc1
            // 
            this.ctlCrcCalc1.InputByteString = "";
            this.ctlCrcCalc1.Location = new System.Drawing.Point(848, 16);
            this.ctlCrcCalc1.Name = "ctlCrcCalc1";
            this.ctlCrcCalc1.Size = new System.Drawing.Size(243, 389);
            this.ctlCrcCalc1.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 433);
            this.Controls.Add(this.ctlCrcCalc1);
            this.Controls.Add(this.ctlConnectionSettings1);
            this.Controls.Add(this.btnAppendCRC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSendCmd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbCmd);
            this.Controls.Add(this.rtbLog);
            this.Name = "FormMain";
            this.Text = "Тестирование LibPorts v.1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.RichTextBox rtbCmd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAppendCRC;
        private PollingLibraries.LibPorts.CtlConnectionSettings ctlConnectionSettings1;
        private CRCCalc.CtlCrcCalc ctlCrcCalc1;
    }
}

