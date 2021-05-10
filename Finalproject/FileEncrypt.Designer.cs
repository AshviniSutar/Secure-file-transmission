namespace Finalproject
{
    partial class FileEncrypt
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
            this.btnbrowsefile = new System.Windows.Forms.Button();
            this.btnsavelocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.txtencryptedfile = new System.Windows.Forms.TextBox();
            this.lblencryptfilenm = new System.Windows.Forms.Label();
            this.btnencrypt = new System.Windows.Forms.Button();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.lblfilename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbrowsefile
            // 
            this.btnbrowsefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnbrowsefile.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowsefile.ForeColor = System.Drawing.Color.White;
            this.btnbrowsefile.Location = new System.Drawing.Point(516, 115);
            this.btnbrowsefile.Name = "btnbrowsefile";
            this.btnbrowsefile.Size = new System.Drawing.Size(109, 32);
            this.btnbrowsefile.TabIndex = 27;
            this.btnbrowsefile.Text = "Browse file";
            this.btnbrowsefile.UseVisualStyleBackColor = false;
            this.btnbrowsefile.Click += new System.EventHandler(this.btnbrowsefile_Click);
            // 
            // btnsavelocation
            // 
            this.btnsavelocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsavelocation.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavelocation.ForeColor = System.Drawing.Color.White;
            this.btnsavelocation.Location = new System.Drawing.Point(516, 174);
            this.btnsavelocation.Name = "btnsavelocation";
            this.btnsavelocation.Size = new System.Drawing.Size(109, 34);
            this.btnsavelocation.TabIndex = 26;
            this.btnsavelocation.Text = "Location";
            this.btnsavelocation.UseVisualStyleBackColor = false;
            this.btnsavelocation.Click += new System.EventHandler(this.btnsavelocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(332, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "File Encryption";
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnnext.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.White;
            this.btnnext.Location = new System.Drawing.Point(291, 242);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(85, 39);
            this.btnnext.TabIndex = 24;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // txtencryptedfile
            // 
            this.txtencryptedfile.Location = new System.Drawing.Point(212, 176);
            this.txtencryptedfile.Name = "txtencryptedfile";
            this.txtencryptedfile.Size = new System.Drawing.Size(264, 20);
            this.txtencryptedfile.TabIndex = 23;
            // 
            // lblencryptfilenm
            // 
            this.lblencryptfilenm.AutoSize = true;
            this.lblencryptfilenm.BackColor = System.Drawing.Color.Transparent;
            this.lblencryptfilenm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblencryptfilenm.ForeColor = System.Drawing.Color.Navy;
            this.lblencryptfilenm.Location = new System.Drawing.Point(24, 174);
            this.lblencryptfilenm.Name = "lblencryptfilenm";
            this.lblencryptfilenm.Size = new System.Drawing.Size(169, 20);
            this.lblencryptfilenm.TabIndex = 22;
            this.lblencryptfilenm.Text = "File after encryption";
            // 
            // btnencrypt
            // 
            this.btnencrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnencrypt.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnencrypt.ForeColor = System.Drawing.Color.White;
            this.btnencrypt.Location = new System.Drawing.Point(132, 242);
            this.btnencrypt.Name = "btnencrypt";
            this.btnencrypt.Size = new System.Drawing.Size(89, 39);
            this.btnencrypt.TabIndex = 21;
            this.btnencrypt.Text = "Encrypt";
            this.btnencrypt.UseVisualStyleBackColor = false;
            this.btnencrypt.Click += new System.EventHandler(this.btnencrypt_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(212, 124);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(264, 20);
            this.txtfilename.TabIndex = 20;
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.BackColor = System.Drawing.Color.Transparent;
            this.lblfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilename.ForeColor = System.Drawing.Color.Navy;
            this.lblfilename.Location = new System.Drawing.Point(24, 122);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(87, 20);
            this.lblfilename.TabIndex = 19;
            this.lblfilename.Text = "File name";
            // 
            // FileEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 362);
            this.Controls.Add(this.btnbrowsefile);
            this.Controls.Add(this.btnsavelocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.txtencryptedfile);
            this.Controls.Add(this.lblencryptfilenm);
            this.Controls.Add(this.btnencrypt);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.lblfilename);
            this.Name = "FileEncrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FileEncrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbrowsefile;
        private System.Windows.Forms.Button btnsavelocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TextBox txtencryptedfile;
        private System.Windows.Forms.Label lblencryptfilenm;
        private System.Windows.Forms.Button btnencrypt;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label lblfilename;

    }
}

