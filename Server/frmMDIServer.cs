using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalproject
{
    public partial class frmMDIServer : Form
    {
        public frmMDIServer()
        {
            InitializeComponent();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server s = new Server();
            s.ShowDialog();
        }

        private void grad2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(first1);
            bunifuTransition1.ShowSync(second1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grad1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbllogin_Click(object sender, EventArgs e)
        {

        }

        private void lbllastlogin_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Server s = new Server();
            s.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(third1);
            bunifuTransition2.ShowSync(fourth1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(second1);
            bunifuTransition2.ShowSync(third1);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void fourth1_Load(object sender, EventArgs e)
        {

        }

        private void second1_Load(object sender, EventArgs e)
        {

        }

        private void third1_Load(object sender, EventArgs e)
        {

        }

        private void first1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            String texttosend = "dfkff";
            TcpClient client = new TcpClient("localhost", 5000);
            NetworkStream nw = client.GetStream();
            byte[] bytetosend = Encoding.ASCII.GetBytes(texttosend);
            Console.WriteLine("Sending" + texttosend);
            //  MessageBox.Show("vmnd");
            nw.Write(bytetosend, 0, bytetosend.Length);
            StreamWriter sw = new StreamWriter(client.GetStream());
            sw.WriteLine(texttosend);
            sw.Flush();
            Console.ReadLine();
            client.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string a = FileDecrypt.passfile.ToString();
            FileStream fsIn = new FileStream(a, FileMode.Open);

            byte[] buffer = new byte[1048576];
            int read;
            if ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
            {
                MessageBox.Show("file is correct");
            }
        }
    }
}
