namespace Finalproject
{
    partial class ImageEncrypt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnbrowseimage = new System.Windows.Forms.Button();
            this.btnlocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.txtimageafterencyption = new System.Windows.Forms.TextBox();
            this.lblencryptfilenm = new System.Windows.Forms.Label();
            this.btnencrypt = new System.Windows.Forms.Button();
            this.txtimage = new System.Windows.Forms.TextBox();
            this.lblfilename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbrowseimage
            // 
            this.btnbrowseimage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnbrowseimage.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowseimage.ForeColor = System.Drawing.Color.White;
            this.btnbrowseimage.Location = new System.Drawing.Point(544, 119);
            this.btnbrowseimage.Name = "btnbrowseimage";
            this.btnbrowseimage.Size = new System.Drawing.Size(109, 32);
            this.btnbrowseimage.TabIndex = 54;
            this.btnbrowseimage.Text = "Browse Image";
            this.btnbrowseimage.UseVisualStyleBackColor = false;
            this.btnbrowseimage.Click += new System.EventHandler(this.btnbrowseimage_Click);
            // 
            // btnlocation
            // 
            this.btnlocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnlocation.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlocation.ForeColor = System.Drawing.Color.White;
            this.btnlocation.Location = new System.Drawing.Point(544, 178);
            this.btnlocation.Name = "btnlocation";
            this.btnlocation.Size = new System.Drawing.Size(109, 34);
            this.btnlocation.TabIndex = 53;
            this.btnlocation.Text = "Location";
            this.btnlocation.UseVisualStyleBackColor = false;
            this.btnlocation.Click += new System.EventHandler(this.btnlocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(360, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "Image Encryption";
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnnext.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.White;
            this.btnnext.Location = new System.Drawing.Point(325, 246);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(85, 39);
            this.btnnext.TabIndex = 51;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // txtimageafterencyption
            // 
            this.txtimageafterencyption.Location = new System.Drawing.Point(240, 180);
            this.txtimageafterencyption.Name = "txtimageafterencyption";
            this.txtimageafterencyption.Size = new System.Drawing.Size(264, 20);
            this.txtimageafterencyption.TabIndex = 50;
            // 
            // lblencryptfilenm
            // 
            this.lblencryptfilenm.AutoSize = true;
            this.lblencryptfilenm.BackColor = System.Drawing.Color.Transparent;
            this.lblencryptfilenm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblencryptfilenm.ForeColor = System.Drawing.Color.Navy;
            this.lblencryptfilenm.Location = new System.Drawing.Point(52, 178);
            this.lblencryptfilenm.Name = "lblencryptfilenm";
            this.lblencryptfilenm.Size = new System.Drawing.Size(192, 20);
            this.lblencryptfilenm.TabIndex = 49;
            this.lblencryptfilenm.Text = "Image after Encryption";
            // 
            // btnencrypt
            // 
            this.btnencrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnencrypt.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnencrypt.ForeColor = System.Drawing.Color.White;
            this.btnencrypt.Location = new System.Drawing.Point(160, 246);
            this.btnencrypt.Name = "btnencrypt";
            this.btnencrypt.Size = new System.Drawing.Size(89, 39);
            this.btnencrypt.TabIndex = 48;
            this.btnencrypt.Text = "Encrypt";
            this.btnencrypt.UseVisualStyleBackColor = false;
            this.btnencrypt.Click += new System.EventHandler(this.btnencrypt_Click);
            // 
            // txtimage
            // 
            this.txtimage.Location = new System.Drawing.Point(240, 128);
            this.txtimage.Name = "txtimage";
            this.txtimage.Size = new System.Drawing.Size(264, 20);
            this.txtimage.TabIndex = 47;
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.BackColor = System.Drawing.Color.Transparent;
            this.lblfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilename.ForeColor = System.Drawing.Color.Navy;
            this.lblfilename.Location = new System.Drawing.Point(52, 126);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(108, 20);
            this.lblfilename.TabIndex = 46;
            this.lblfilename.Text = "Image name";
            // 
            // ImageEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.btnbrowseimage);
            this.Controls.Add(this.btnlocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.txtimageafterencyption);
            this.Controls.Add(this.lblencryptfilenm);
            this.Controls.Add(this.btnencrypt);
            this.Controls.Add(this.txtimage);
            this.Controls.Add(this.lblfilename);
            this.Name = "ImageEncrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImageEncrypt";
            this.Load += new System.EventHandler(this.ImageEncrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbrowseimage;
        private System.Windows.Forms.Button btnlocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TextBox txtimageafterencyption;
        private System.Windows.Forms.Label lblencryptfilenm;
        private System.Windows.Forms.Button btnencrypt;
        private System.Windows.Forms.TextBox txtimage;
        private System.Windows.Forms.Label lblfilename;
    }
}