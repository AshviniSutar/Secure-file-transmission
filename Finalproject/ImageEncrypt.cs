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
    public partial class ImageEncrypt : Form
    {
        string key;
        public ImageEncrypt()
        {
            InitializeComponent();
            key = generateKey();
        }

        private string generateKey()
        {
            DESCryptoServiceProvider descrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            return ASCIIEncoding.ASCII.GetString(descrypto.Key);
        }

        private void encrypt(string input, string output, string strHash)
        {
           
            string EncryptionKey = "MAKV2SPBNI99212";
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (FileStream fsOutput = new FileStream(output, FileMode.Create))
                {
                    using (CryptoStream cs = new CryptoStream(fsOutput, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (FileStream fsInput = new FileStream(input, FileMode.Open))
                        {
                            int data;
                            while ((data = fsInput.ReadByte()) != -1)
                            {
                                cs.WriteByte((byte)data);
                            }
                        }
                    }
                }
            }

        }

        private void ImageEncrypt_Load(object sender, EventArgs e)
        {

        }

        private void btnbrowseimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            txtimage.Text = open.FileName;
           
            //StreamReader read = new StreamReader(File.OpenRead(open.FileName));
            open.Dispose();
           // read.Dispose();
        }

        private void btnencrypt_Click(object sender, EventArgs e)
        {
            if (txtimage.Text == String.Empty || txtimageafterencyption.Text == String.Empty)
            {
                MessageBox.Show("Encrypton information is incomplete!\nPlease complete them frist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                encrypt(txtimage.Text, txtimageafterencyption.Text, key);
                MessageBox.Show("Image encrypted successfully");
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Client f1 = new Client();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void btnlocation_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();

            txtimageafterencyption.Text = save.FileName;
            save.Dispose();
        }
    }
}
