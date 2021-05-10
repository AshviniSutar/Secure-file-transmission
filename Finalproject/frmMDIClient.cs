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
    public partial class frmMDIClient : Form
    {
        DateTime dt0, dt1, dt2;
        string lastintime, lastouttime;
        public frmMDIClient()
        {
            InitializeComponent();
        }



        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            c.ShowDialog();
        }

        private void fileEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileEncrypt fe = new FileEncrypt();
            fe.ShowDialog();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
        }

        private void encryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imageEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageEncrypt en = new ImageEncrypt();
            en.ShowDialog();
        }

        private void steganographyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Steganoencrypt st = new Steganoencrypt();
            st.ShowDialog();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMDIClient_Load(object sender, EventArgs e)
        {
            lbllogin.Text = "Log-In Time :  " + DateTime.Now.ToLongDateString() + " [ " + DateTime.Now.ToLongTimeString() + " ] ";
            lastintime = DateTime.Now.ToLongDateString() + " [ " + DateTime.Now.ToLongTimeString() + " ] ";
            dt0 = DateTime.Now;
          //  lastLoginTime();
            dt2 = DateTime.Now;
        }

     /*   public void lastLoginTime()
        {
            try
            {
                cm1 = new SqlCommand("select * from logManager", cn);
                dr = cm1.ExecuteReader();
                dt.Load(dr);
                int y = dt.Rows.Count - 1;
                lbllastlogin.Text = "Last Log-In Time :  " + dt.Rows[y].ItemArray[1].ToString();
                dr.Close();
            }
            catch
            {
                lbllastlogin.Text = "Last Log-In Time :  - - -";
            }

        }*/

        
      
        private void button1_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(firstUc1);
            bunifuTransition2.ShowSync(seconduc1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(seconduc1);
            bunifuTransition2.ShowSync(thirduc1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(thirduc1);
            bunifuTransition2.ShowSync(fourthuc1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Client s = new Client();
            s.ShowDialog();
        }

      
    }
}
