namespace project
{
    partial class Add
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.over = new System.Windows.Forms.Label();
            this.gpOver = new System.Windows.Forms.GroupBox();
            this.rdNo = new System.Windows.Forms.RadioButton();
            this.rdYes = new System.Windows.Forms.RadioButton();
            this.btnCmp = new System.Windows.Forms.Button();
            this.lbCheck = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gpOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTitle.Location = new System.Drawing.Point(40, 44);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(33, 13);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "제목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(40, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "기간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(40, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "설문항목";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(115, 41);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(461, 21);
            this.txtTitle.TabIndex = 3;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(6, 14);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 21);
            this.startDate.TabIndex = 4;
            this.startDate.Value = new System.DateTime(2022, 6, 15, 0, 0, 0, 0);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(246, 14);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 21);
            this.endDate.TabIndex = 5;
            this.endDate.Value = new System.DateTime(2022, 6, 20, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.endDate);
            this.groupBox1.Controls.Add(this.startDate);
            this.groupBox1.Location = new System.Drawing.Point(112, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 40);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "~";
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.over.Location = new System.Drawing.Point(40, 94);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(59, 13);
            this.over.TabIndex = 7;
            this.over.Text = "중복투표";
            // 
            // gpOver
            // 
            this.gpOver.Controls.Add(this.rdNo);
            this.gpOver.Controls.Add(this.rdYes);
            this.gpOver.Location = new System.Drawing.Point(112, 80);
            this.gpOver.Name = "gpOver";
            this.gpOver.Size = new System.Drawing.Size(233, 37);
            this.gpOver.TabIndex = 8;
            this.gpOver.TabStop = false;
            // 
            // rdNo
            // 
            this.rdNo.AutoSize = true;
            this.rdNo.Location = new System.Drawing.Point(159, 14);
            this.rdNo.Name = "rdNo";
            this.rdNo.Size = new System.Drawing.Size(47, 16);
            this.rdNo.TabIndex = 1;
            this.rdNo.TabStop = true;
            this.rdNo.Text = "불가";
            this.rdNo.UseVisualStyleBackColor = true;
            // 
            // rdYes
            // 
            this.rdYes.AutoSize = true;
            this.rdYes.Location = new System.Drawing.Point(17, 15);
            this.rdYes.Name = "rdYes";
            this.rdYes.Size = new System.Drawing.Size(47, 16);
            this.rdYes.TabIndex = 0;
            this.rdYes.TabStop = true;
            this.rdYes.Text = "가능";
            this.rdYes.UseVisualStyleBackColor = true;
            // 
            // btnCmp
            // 
            this.btnCmp.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCmp.Location = new System.Drawing.Point(665, 535);
            this.btnCmp.Name = "btnCmp";
            this.btnCmp.Size = new System.Drawing.Size(87, 33);
            this.btnCmp.TabIndex = 9;
            this.btnCmp.Text = "완료";
            this.btnCmp.UseVisualStyleBackColor = true;
            this.btnCmp.Click += new System.EventHandler(this.btnCmp_Click);
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.Location = new System.Drawing.Point(115, 535);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(0, 12);
            this.lbCheck.TabIndex = 13;
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt1.Location = new System.Drawing.Point(115, 245);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(589, 22);
            this.txt1.TabIndex = 14;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt2.Location = new System.Drawing.Point(115, 278);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(589, 22);
            this.txt2.TabIndex = 15;
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt3.Location = new System.Drawing.Point(115, 316);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(589, 22);
            this.txt3.TabIndex = 16;
            // 
            // txt4
            // 
            this.txt4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt4.Location = new System.Drawing.Point(115, 353);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(589, 22);
            this.txt4.TabIndex = 17;
            // 
            // txt5
            // 
            this.txt5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt5.Location = new System.Drawing.Point(115, 391);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(589, 22);
            this.txt5.TabIndex = 18;
            // 
            // txt6
            // 
            this.txt6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt6.Location = new System.Drawing.Point(115, 431);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(589, 22);
            this.txt6.TabIndex = 19;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.btnCmp);
            this.Controls.Add(this.gpOver);
            this.Controls.Add(this.over);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitle);
            this.Name = "Add";
            this.Text = "추가";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpOver.ResumeLayout(false);
            this.gpOver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.GroupBox gpOver;
        private System.Windows.Forms.RadioButton rdNo;
        private System.Windows.Forms.RadioButton rdYes;
        private System.Windows.Forms.Label lbCheck;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.DateTimePicker startDate;
        public System.Windows.Forms.DateTimePicker endDate;
        public System.Windows.Forms.TextBox txt1;
        public System.Windows.Forms.TextBox txt3;
        public System.Windows.Forms.TextBox txt4;
        public System.Windows.Forms.TextBox txt5;
        public System.Windows.Forms.TextBox txt6;
        public System.Windows.Forms.TextBox txt2;
        public System.Windows.Forms.Button btnCmp;
    }
}