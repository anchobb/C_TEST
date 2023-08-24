namespace TEST_KYS
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortNumber = new System.Windows.Forms.ComboBox();
            this.Conn_btn = new System.Windows.Forms.Button();
            this.On_btn_01 = new System.Windows.Forms.Button();
            this.Off_btn_01 = new System.Windows.Forms.Button();
            this.On_btn_02 = new System.Windows.Forms.Button();
            this.Off_btn_02 = new System.Windows.Forms.Button();
            this.msg_Label = new System.Windows.Forms.Label();
            this.msgArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PortNumber
            // 
            this.PortNumber.FormattingEnabled = true;
            this.PortNumber.Items.AddRange(new object[] {
            "COM1",
            "COM2"});
            this.PortNumber.Location = new System.Drawing.Point(23, 30);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(129, 23);
            this.PortNumber.TabIndex = 0;
            // 
            // Conn_btn
            // 
            this.Conn_btn.Location = new System.Drawing.Point(173, 30);
            this.Conn_btn.Name = "Conn_btn";
            this.Conn_btn.Size = new System.Drawing.Size(129, 23);
            this.Conn_btn.TabIndex = 1;
            this.Conn_btn.Text = "연결";
            this.Conn_btn.UseVisualStyleBackColor = true;
            this.Conn_btn.Click += new System.EventHandler(this.Conn_btn_Click);
            // 
            // On_btn_01
            // 
            this.On_btn_01.Location = new System.Drawing.Point(23, 78);
            this.On_btn_01.Name = "On_btn_01";
            this.On_btn_01.Size = new System.Drawing.Size(129, 57);
            this.On_btn_01.TabIndex = 2;
            this.On_btn_01.Text = "LED_01 ON";
            this.On_btn_01.UseVisualStyleBackColor = true;
            this.On_btn_01.Click += new System.EventHandler(this.On_btn_01_Click);
            // 
            // Off_btn_01
            // 
            this.Off_btn_01.Location = new System.Drawing.Point(173, 78);
            this.Off_btn_01.Name = "Off_btn_01";
            this.Off_btn_01.Size = new System.Drawing.Size(129, 57);
            this.Off_btn_01.TabIndex = 3;
            this.Off_btn_01.Text = "LED_01 OFF";
            this.Off_btn_01.UseVisualStyleBackColor = true;
            this.Off_btn_01.Click += new System.EventHandler(this.Off_btn_01_Click);
            // 
            // On_btn_02
            // 
            this.On_btn_02.Location = new System.Drawing.Point(23, 150);
            this.On_btn_02.Name = "On_btn_02";
            this.On_btn_02.Size = new System.Drawing.Size(129, 57);
            this.On_btn_02.TabIndex = 4;
            this.On_btn_02.Text = "LED_02 ON";
            this.On_btn_02.UseVisualStyleBackColor = true;
            this.On_btn_02.Click += new System.EventHandler(this.On_btn_02_Click);
            // 
            // Off_btn_02
            // 
            this.Off_btn_02.Location = new System.Drawing.Point(173, 150);
            this.Off_btn_02.Name = "Off_btn_02";
            this.Off_btn_02.Size = new System.Drawing.Size(129, 57);
            this.Off_btn_02.TabIndex = 5;
            this.Off_btn_02.Text = "LED_02 OFF";
            this.Off_btn_02.UseVisualStyleBackColor = true;
            this.Off_btn_02.Click += new System.EventHandler(this.Off_btn_02_Click);
            // 
            // msg_Label
            // 
            this.msg_Label.AutoSize = true;
            this.msg_Label.Location = new System.Drawing.Point(20, 229);
            this.msg_Label.Name = "msg_Label";
            this.msg_Label.Size = new System.Drawing.Size(77, 15);
            this.msg_Label.TabIndex = 6;
            this.msg_Label.Text = "Message :";
            // 
            // msgArea
            // 
            this.msgArea.Location = new System.Drawing.Point(23, 251);
            this.msgArea.Name = "msgArea";
            this.msgArea.ReadOnly = true;
            this.msgArea.Size = new System.Drawing.Size(279, 25);
            this.msgArea.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 314);
            this.Controls.Add(this.msgArea);
            this.Controls.Add(this.msg_Label);
            this.Controls.Add(this.Off_btn_02);
            this.Controls.Add(this.On_btn_02);
            this.Controls.Add(this.Off_btn_01);
            this.Controls.Add(this.On_btn_01);
            this.Controls.Add(this.Conn_btn);
            this.Controls.Add(this.PortNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortNumber;
        private System.Windows.Forms.Button Conn_btn;
        private System.Windows.Forms.Button On_btn_01;
        private System.Windows.Forms.Button Off_btn_01;
        private System.Windows.Forms.Button On_btn_02;
        private System.Windows.Forms.Button Off_btn_02;
        private System.Windows.Forms.Label msg_Label;
        private System.Windows.Forms.TextBox msgArea;
    }
}

