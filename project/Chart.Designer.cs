namespace project
{
    partial class Chart
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
            this.button1 = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.pieChart1 = new LiveCharts.Wpf.PieChart();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.defaultLegend2 = new LiveCharts.Wpf.DefaultLegend();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.defaultLegend1 = new LiveCharts.Wpf.DefaultLegend();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(667, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "처음으로";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(22, 22);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(240, 165);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.pieChart1;
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(22, 216);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(240, 163);
            this.elementHost2.TabIndex = 2;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.defaultLegend2;
            // 
            // elementHost3
            // 
            this.elementHost3.Location = new System.Drawing.Point(22, 405);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(240, 173);
            this.elementHost3.TabIndex = 3;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.defaultLegend1;
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.elementHost3);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.button1);
            this.Name = "Chart";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.PieChart pieChart1;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private LiveCharts.Wpf.DefaultLegend defaultLegend1;
        private LiveCharts.Wpf.DefaultLegend defaultLegend2;
    }
}