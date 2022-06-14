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
    public partial class Add : Form
    {
        Admin mainF;
        public Add()
        {
            InitializeComponent();
        }

        public Add(Admin _mainF)
        {
            InitializeComponent();
            mainF = _mainF;
        }
        public void btnCmp_Click(object sender, EventArgs e)
        {
            if (EmptyCheck())
            {
                this.Close();

            }
            
            
        }
        private bool EmptyCheck()
        {
            lbCheck.ForeColor = System.Drawing.Color.Red;
            if (String.IsNullOrEmpty(txtTitle.Text))
            {
                lbCheck.Text = "제목을 입력해 주세요";
                txtTitle.Focus();
                return false;
            }
            else if (!rdYes.Checked && !rdNo.Checked)
            {
                lbCheck.Text = "중복여부가 누락되었습니다.";
                return false;
            }
            

            return true;
        }
    }
}
