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
    public partial class Imagedecrypt : Form
    {
        string key;
        public static string passimgdecrypt;
        public Imagedecrypt()
        {
            InitializeComponent();
            key = generateKey();
        }

        private string generateKey()
        {
            DESCryptoServiceProvider descrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            return ASCIIEncoding.ASCII.GetString(descrypto.Key);
        }

        private void decrypt(string input, string output, string strHash)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (FileStream fsInput = new FileStream(input, FileMode.Open))
                {
                    using (CryptoStream cs = new CryptoStream(fsInput, encryptor.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (FileStream fsOutput = new FileStream(output, FileMode.Create))
                        {
                            int data;
                            while ((data = cs.ReadByte()) != -1)
                            {
                                fsOutput.WriteByte((byte)data);
                            }
                        }
                    }
                }
            }

        }

        private void Imagedecrypt_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();

            txtimage.Text = open.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnbrowseimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();

            txtimage.Text = open.FileName;
        }

        private void btnlocation_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();

            txtimageafterdecryption.Text = save.FileName;
            passimgdecrypt = txtimageafterdecryption.Text;

        }

        private void btndecrypt_Click(object sender, EventArgs e)
        {
            decrypt(txtimage.Text, txtimageafterdecryption.Text, key);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Steganodecrypt f1 = new Steganodecrypt();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

       
    }
}
