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
namespace Finalproject
{
    public partial class FileDecrypt : Form
    {
        public static string passfile;
        public FileDecrypt()
        {
            InitializeComponent();
        }

        public static byte[] GenerateSalt()
        {
            byte[] data = new byte[32];
            using (RNGCryptoServiceProvider rgnCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rgnCryptoServiceProvider.GetBytes(data);
            }
            return data;
        }

        private void Decrypt(string input, string output, string password)
        {

            byte[] passwords = Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];
            using (FileStream fsCrypt = new FileStream(input, FileMode.Open))
            {
                fsCrypt.Read(salt, 0, salt.Length);
                RijndaelManaged AES = new RijndaelManaged();
                AES.KeySize = 256;//aes 256 bit encryption c#
                AES.BlockSize = 128;//aes 128 bit encryption c#
                var key = new Rfc2898DeriveBytes(passwords, salt, 50000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Padding = PaddingMode.PKCS7;
                AES.Mode = CipherMode.CFB;
                using (CryptoStream cryptoStream = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    using (FileStream fsOut = new FileStream(output, FileMode.Create))
                    {
                        int read;
                        byte[] buffer = new byte[1048576];
                        while ((read = cryptoStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fsOut.Write(buffer, 0, read);
                        }
                    }
                }
            }
        }

        private void FileDecrypt_Load(object sender, EventArgs e)
        {

        }

        private void btnbrowsefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();

            txtfilename.Text = open.FileName;
        }

        private void btnlocation_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();

            txtlocation.Text = save.FileName;
            passfile = txtlocation.Text;
        }

        private void btndecrypt_Click(object sender, EventArgs e)
        {
            string password = "foxlearn.com";
            if (txtfilename.Text == String.Empty ||txtlocation.Text == String.Empty)
            {
                MessageBox.Show("Encrypton information is incomplete!\nPlease complete them frist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Decrypt(txtfilename.Text, txtlocation.Text, password);
                MessageBox.Show("File decrypted successfully");
                
            }

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
           Server dec = new Server();
            this.Hide();
            dec.ShowDialog();
            this.Close();
        }
    }
}
