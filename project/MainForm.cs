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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Survey svy = new Survey();
            svy.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginForm loginF = new LoginForm();
            loginF.Show();

        }
    }
}
