using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finalproject.UserControls;
namespace Finalproject
{
    public partial class FileEncrypt : Form
    {
        public FileEncrypt()
        {
            InitializeComponent();
        }

        public static string passencryptedfile;
        string a;
        string b;
        string c;
        public static byte[] GenerateSalt()
        {
            byte[] data = new byte[32];
            using (RNGCryptoServiceProvider rgnCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rgnCryptoServiceProvider.GetBytes(data);
            }
            return data;
        }

        private void Encrypt(string input, string output, string password)
        {
            byte[] salt = GenerateSalt();
            byte[] passwords = Encoding.UTF8.GetBytes(password);
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;//aes 256 bit encryption c#
            AES.BlockSize = 128;//aes 128 bit encryption c#
            AES.Padding = PaddingMode.PKCS7;
            var key = new Rfc2898DeriveBytes(passwords, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Mode = CipherMode.CFB;
            using (FileStream fsCrypt = new FileStream(txtencryptedfile.Text, FileMode.Create))
            {
                fsCrypt.Write(salt, 0, salt.Length);
                using (CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using (FileStream fsIn = new FileStream(input, FileMode.Open))
                    {
                        byte[] buffer = new byte[1048576];
                        int read;
                        while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            cs.Write(buffer, 0, read);
                        }

                    }
                }
            }
        }

        private void FileEncrypt_Load(object sender, EventArgs e)
        {
        
        }

        private void btnbrowsefile_Click(object sender, EventArgs e)
        {
            a = Seconduc.pass.ToString();
            b = Seconduc.pass1.ToString();
            c = Seconduc.pass2.ToString();
            OpenFileDialog open = new OpenFileDialog();
            if (a=="true")
            {
                open.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";
            }
            else if (b=="true")
            {
                open.Filter = "Document Files (*.docx)|*.docx|All files(*.*)|*.*";
            }
            else if (c == "true")
            {
                open.Filter = "Pdf Files (*.pdf)|*.pdf|All files(*.*)|*.*";
            }
            open.ShowDialog();

           txtfilename.Text = open.FileName;
        }

        private void btnsavelocation_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();

           txtencryptedfile.Text = save.FileName;
        }

        private void btnencrypt_Click(object sender, EventArgs e)
        {
            string password = "foxlearn.com";
            if (txtfilename.Text == String.Empty || txtencryptedfile.Text == String.Empty)
            {
                MessageBox.Show("Encrypton information is incomplete!\nPlease complete them frist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Encrypt(txtfilename.Text, txtencryptedfile.Text, password);
                passencryptedfile = txtencryptedfile.Text;
                MessageBox.Show("File encrypted successfully");
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Steganoencrypt s = new Steganoencrypt();
            this.Hide();
            s.ShowDialog();
            this.Close();
        }
    }
}
