namespace project
{
    partial class Admin
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.check = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdapt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(12, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // list
            // 
            this.list.CheckBoxes = true;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.check,
            this.no,
            this.title,
            this.qnum,
            this.date,
            this.reg,
            this.result});
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(12, 141);
            this.list.Name = "list";
            this.list.OwnerDraw = true;
            this.list.Size = new System.Drawing.Size(1081, 297);
            this.list.TabIndex = 1;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.list_DrawColumnHeader);
            this.list.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.list_DrawItem);
            this.list.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.list_DrawSubItem);
            // 
            // check
            // 
            this.check.Text = "";
            this.check.Width = 41;
            // 
            // no
            // 
            this.no.Text = "번호";
            this.no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // title
            // 
            this.title.Text = "제목";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.Width = 285;
            // 
            // qnum
            // 
            this.qnum.Text = "문항";
            this.qnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date
            // 
            this.date.Text = "기간";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Width = 310;
            // 
            // reg
            // 
            this.reg.Text = "등록일";
            this.reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reg.Width = 250;
            // 
            // result
            // 
            this.result.Text = "결과";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(174, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdapt
            // 
            this.btnAdapt.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdapt.Location = new System.Drawing.Point(93, 91);
            this.btnAdapt.Name = "btnAdapt";
            this.btnAdapt.Size = new System.Drawing.Size(75, 23);
            this.btnAdapt.TabIndex = 3;
            this.btnAdapt.Text = "수정";
            this.btnAdapt.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 450);
            this.Controls.Add(this.btnAdapt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.list);
            this.Controls.Add(this.btnAdd);
            this.Name = "Admin";
            this.Text = "관리자 페이지";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader check;
        private System.Windows.Forms.ColumnHeader no;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader qnum;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader result;
        private System.Windows.Forms.Button btnAdapt;
        private System.Windows.Forms.ColumnHeader reg;
    }
}