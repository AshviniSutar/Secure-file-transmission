namespace Finalproject
{
    partial class FileDecrypt
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
            this.btnlocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.lblencryptfilenm = new System.Windows.Forms.Label();
            this.btndecrypt = new System.Windows.Forms.Button();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.lblfilename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbrowsefile
            // 
            this.btnbrowsefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnbrowsefile.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowsefile.ForeColor = System.Drawing.Color.White;
            this.btnbrowsefile.Location = new System.Drawing.Point(517, 104);
            this.btnbrowsefile.Name = "btnbrowsefile";
            this.btnbrowsefile.Size = new System.Drawing.Size(109, 32);
            this.btnbrowsefile.TabIndex = 36;
            this.btnbrowsefile.Text = "Browse file";
            this.btnbrowsefile.UseVisualStyleBackColor = false;
            this.btnbrowsefile.Click += new System.EventHandler(this.btnbrowsefile_Click);
            // 
            // btnlocation
            // 
            this.btnlocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnlocation.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlocation.ForeColor = System.Drawing.Color.White;
            this.btnlocation.Location = new System.Drawing.Point(517, 163);
            this.btnlocation.Name = "btnlocation";
            this.btnlocation.Size = new System.Drawing.Size(109, 34);
            this.btnlocation.TabIndex = 35;
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
            this.label1.Location = new System.Drawing.Point(333, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "File Decryption";
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnnext.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.White;
            this.btnnext.Location = new System.Drawing.Point(292, 231);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(85, 39);
            this.btnnext.TabIndex = 33;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(213, 165);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(264, 20);
            this.txtlocation.TabIndex = 32;
            // 
            // lblencryptfilenm
            // 
            this.lblencryptfilenm.AutoSize = true;
            this.lblencryptfilenm.BackColor = System.Drawing.Color.Transparent;
            this.lblencryptfilenm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblencryptfilenm.ForeColor = System.Drawing.Color.Navy;
            this.lblencryptfilenm.Location = new System.Drawing.Point(25, 163);
            this.lblencryptfilenm.Name = "lblencryptfilenm";
            this.lblencryptfilenm.Size = new System.Drawing.Size(172, 20);
            this.lblencryptfilenm.TabIndex = 31;
            this.lblencryptfilenm.Text = "File after Decryption";
            // 
            // btndecrypt
            // 
            this.btndecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndecrypt.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndecrypt.ForeColor = System.Drawing.Color.White;
            this.btndecrypt.Location = new System.Drawing.Point(133, 231);
            this.btndecrypt.Name = "btndecrypt";
            this.btndecrypt.Size = new System.Drawing.Size(89, 39);
            this.btndecrypt.TabIndex = 30;
            this.btndecrypt.Text = "Decrypt";
            this.btndecrypt.UseVisualStyleBackColor = false;
            this.btndecrypt.Click += new System.EventHandler(this.btndecrypt_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(213, 113);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(264, 20);
            this.txtfilename.TabIndex = 29;
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.BackColor = System.Drawing.Color.Transparent;
            this.lblfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilename.ForeColor = System.Drawing.Color.Navy;
            this.lblfilename.Location = new System.Drawing.Point(25, 111);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(87, 20);
            this.lblfilename.TabIndex = 28;
            this.lblfilename.Text = "File name";
            // 
            // FileDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 312);
            this.Controls.Add(this.btnbrowsefile);
            this.Controls.Add(this.btnlocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.lblencryptfilenm);
            this.Controls.Add(this.btndecrypt);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.lblfilename);
            this.Name = "FileDecrypt";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FileDecrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbrowsefile;
        private System.Windows.Forms.Button btnlocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Label lblencryptfilenm;
        private System.Windows.Forms.Button btndecrypt;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label lblfilename;
    }
}

