using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Add addF = new Add(this);
            addF.ShowDialog();

            ListViewItem item = new ListViewItem();
            item.SubItems.Add((list.Items.Count + 1).ToString());
            item.SubItems.Add(addF.txtTitle.Text);
            int count = 0;
            if (addF.txt1.Text != "") count++;
            if (addF.txt2.Text != "") count++;
            if (addF.txt3.Text != "") count++;
            if (addF.txt4.Text != "") count++;
            if (addF.txt5.Text != "") count++;
            if (addF.txt6.Text != "") count++;
            item.SubItems.Add(count.ToString());
            item.SubItems.Add((addF.startDate.Value).ToString() + " ~ " + (addF.endDate.Value).ToString());
            item.SubItems.Add(DateTime.Now.ToString());

            list.Items.Add(item);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (var item in list.CheckedItems)
            {
                list.Items.Remove((ListViewItem)item);
            }

        }

        private void list_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                CheckBox check = new CheckBox();
                list.SuspendLayout(); //컨트롤의 레이아웃 논리를 임시로 일시중단
                
                list.Controls.Add(check);
                check.Show();
                Visible = true;
                check.Click += new EventHandler(Bink);
                list.ResumeLayout(true);

            }
            else
            {
                e.DrawDefault = true;
            }
        }
        private void Bink(object sender, System.EventArgs e)
        {
            CheckBox ck = sender as CheckBox;
            for(int i=0; i<list.Items.Count; i++)
            {
                list.Items[i].Checked = ck.Checked;
            }
        }

        private void list_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void list_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
