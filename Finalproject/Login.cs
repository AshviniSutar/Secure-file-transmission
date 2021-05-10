using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalproject
{
    public partial class Login : Form
    {
        static int attempt = 2;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void btncancle_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (attempt == 0)
            {
                MessageBox.Show("Invalid UserName and Password.....!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            if (txtusername.Text.Equals("Ashvini") && txtpassword.Text.Equals("Ashvini"))
            {
              //  pass = txtusername.Text.ToString();
                MessageBox.Show("Login Successfull.....!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMDIClient ff = new frmMDIClient();
                ff.ShowDialog();

            }
            else
            {
                MessageBox.Show("You have to login only in   " + Convert.ToString(attempt) + "  Attempts...!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                --attempt;
                Clear();
            }
        }
    }
}
