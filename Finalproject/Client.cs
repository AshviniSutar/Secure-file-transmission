using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Finalproject
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

       // string n;
        byte[] b1;
        string rd;
        OpenFileDialog op;
        IPAddress ipadress = IPAddress.Parse("127.0.0.1");
        const int port = 5000;
        const string serverip = "127.0.0.1";
        public static string n;
        private void Client_Load(object sender, EventArgs e)
        {
            
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtfilename.Text = op.FileName;
                
                string t = txtfilename.Text;
                t = op.FileName;
                FileInfo fi = new FileInfo(t);
                n = fi.Name + "." + fi.Length;
                TcpClient client = new TcpClient("localhost", 8000);
                StreamWriter sw = new StreamWriter(client.GetStream());
                sw.WriteLine(n);
                sw.Flush();
                //label1.Text = "File Transferred....";
            }
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            
            TcpClient client = new TcpClient("localhost", 8000);
            Stream s = client.GetStream();

            b1 = File.ReadAllBytes(op.FileName);
            s.Write(b1, 0, b1.Length);

            StreamWriter writer = new StreamWriter(client.GetStream());
            writer.AutoFlush = true;
          // writer.WriteLine("My message");

            client.Close();
            label1.Visible = true;
            label1.Text = "File Transferred....";
        }

        private void btnstatus_Click(object sender, EventArgs e)
        {
            
            TcpListener list1 = new TcpListener(ipadress, port);
            list1.Start();
            TcpClient client = list1.AcceptTcpClient();
            MessageBox.Show("Client trying to connect");
            StreamReader sr = new StreamReader(client.GetStream());
            NetworkStream nw1 = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int byteread = nw1.Read(buffer, 0, client.ReceiveBufferSize);
            string datareceived = Encoding.ASCII.GetString(buffer, 0, byteread);
            Console.WriteLine("Received" + datareceived);
            label1.Text = datareceived;
            MessageBox.Show(datareceived);
            //  Console.WriteLine("sending back" + datareceived);
            nw1.Write(buffer, 0, byteread);
            client.Close();
        }
    }
}
