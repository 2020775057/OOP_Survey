namespace project
{
    partial class LoginForm
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
            this.btnLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.checkLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(368, 80);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(110, 52);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "로그인";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "비밀번호";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(148, 68);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(172, 21);
            this.id.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(148, 117);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.Size = new System.Drawing.Size(172, 21);
            this.Password.TabIndex = 3;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Location = new System.Drawing.Point(148, 160);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(0, 12);
            this.checkLabel.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 215);
            this.Controls.Add(this.checkLabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLog);
            this.Name = "LoginForm";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label checkLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

