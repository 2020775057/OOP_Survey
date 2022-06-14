using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class LoginForm : Form
    {
    
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                btnLog_Click(sender, e);
            }
        }
        
        private void btnLog_Click(object sender, EventArgs e)
        {   
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\전유림\Documents\dblogin.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from USERINFO where Id='"+id.Text+"' and Password = '"+Password.Text+"'", con);

            DataTable newTable = new DataTable();
            sda.Fill(newTable);


            if (newTable.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Admin adF = new Admin();
                adF.Show();
            }
            else
            {
                checkLabel.Text = "아이디나 비밀번호가 올바르지 않습니다.";
                checkLabel.ForeColor = System.Drawing.Color.Red;
                id.Focus();
            }
            
            /*if (Empty())
            {
                if (id.Text == "wjsdbfla" && Password.Text == "2020775057")
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    Admin adF = new Admin();
                    adF.Show();
                }
                else
                {
                    checkLabel.Text = "아이디나 비밀번호가 올바르지 않습니다.";
                    checkLabel.ForeColor = Color.Red;
                    id.Focus();
                }
            
            }
            */
        }
    
        /*
        private bool Empty()
        {
            if (String.IsNullOrEmpty(id.Text))
            {
                checkLabel.Text = "아이디를 입력해주세요";
                checkLabel.ForeColor = Color.Red;
                id.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(Password.Text))
            {
                checkLabel.Text = "비밀번호를 입력해주세요";
                checkLabel.ForeColor = Color.Red;
                Password.Focus();
                return false;
            }
            return true;
        }
        */
    }
}
