namespace Finalproject
{
    partial class frmMDIServer
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIServer));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.grad1 = new Finalproject.Grad();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.first1 = new Finalproject.UserControls.First();
            this.grad2 = new Finalproject.Grad();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.third1 = new Finalproject.UserControls.steganimgdec();
            this.second1 = new Finalproject.UserControls.imgdec();
            this.fourth1 = new Finalproject.UserControls.filedec();
            this.grad1.SuspendLayout();
            this.grad2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 1F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation2;
            // 
            // grad1
            // 
            this.grad1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grad1.ColorTop = System.Drawing.Color.Empty;
            this.grad1.Controls.Add(this.button9);
            this.grad1.Controls.Add(this.button8);
            this.grad1.Controls.Add(this.button3);
            this.grad1.Controls.Add(this.button6);
            this.grad1.Controls.Add(this.label1);
            this.grad1.Controls.Add(this.button7);
            this.bunifuTransition2.SetDecoration(this.grad1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.grad1, BunifuAnimatorNS.DecorationType.None);
            this.grad1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grad1.Location = new System.Drawing.Point(0, 0);
            this.grad1.Name = "grad1";
            this.grad1.Size = new System.Drawing.Size(886, 56);
            this.grad1.TabIndex = 8;
            this.grad1.Paint += new System.Windows.Forms.PaintEventHandler(this.grad1_Paint);
            // 
            // button9
            // 
            this.bunifuTransition1.SetDecoration(this.button9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button9, BunifuAnimatorNS.DecorationType.None);
            this.button9.Location = new System.Drawing.Point(541, 24);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "send status";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.bunifuTransition1.SetDecoration(this.button8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button8, BunifuAnimatorNS.DecorationType.None);
            this.button8.Location = new System.Drawing.Point(387, 24);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "check";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(655, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 56);
            this.button3.TabIndex = 5;
            this.button3.Text = "About us";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.button6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(742, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 56);
            this.button6.TabIndex = 6;
            this.button6.Text = "Help";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.button7.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(809, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 56);
            this.button7.TabIndex = 7;
            this.button7.Text = "Logout";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // first1
            // 
            this.first1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.first1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.first1, BunifuAnimatorNS.DecorationType.None);
            this.first1.Location = new System.Drawing.Point(1, 58);
            this.first1.Name = "first1";
            this.first1.Size = new System.Drawing.Size(885, 377);
            this.first1.TabIndex = 25;
            this.first1.Load += new System.EventHandler(this.first1_Load);
            // 
            // grad2
            // 
            this.grad2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grad2.ColorTop = System.Drawing.Color.Empty;
            this.grad2.Controls.Add(this.button1);
            this.grad2.Controls.Add(this.button4);
            this.grad2.Controls.Add(this.button5);
            this.grad2.Controls.Add(this.button2);
            this.bunifuTransition2.SetDecoration(this.grad2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.grad2, BunifuAnimatorNS.DecorationType.None);
            this.grad2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grad2.Location = new System.Drawing.Point(0, 432);
            this.grad2.Name = "grad2";
            this.grad2.Size = new System.Drawing.Size(886, 80);
            this.grad2.TabIndex = 21;
            this.grad2.Paint += new System.Windows.Forms.PaintEventHandler(this.grad2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(95, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 80);
            this.button1.TabIndex = 15;
            this.button1.Text = "Image_Decryption";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuTransition1.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(400, -2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 80);
            this.button4.TabIndex = 17;
            this.button4.Text = "File Decryption";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuTransition1.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 80);
            this.button5.TabIndex = 18;
            this.button5.Text = "Server";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(268, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 80);
            this.button2.TabIndex = 16;
            this.button2.Text = "File Extracting";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // third1
            // 
            this.bunifuTransition1.SetDecoration(this.third1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.third1, BunifuAnimatorNS.DecorationType.None);
            this.third1.Location = new System.Drawing.Point(0, 58);
            this.third1.Name = "third1";
            this.third1.Size = new System.Drawing.Size(886, 377);
            this.third1.TabIndex = 24;
            this.third1.Visible = false;
            this.third1.Load += new System.EventHandler(this.third1_Load);
            // 
            // second1
            // 
            this.bunifuTransition1.SetDecoration(this.second1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.second1, BunifuAnimatorNS.DecorationType.None);
            this.second1.Location = new System.Drawing.Point(0, 58);
            this.second1.Name = "second1";
            this.second1.Size = new System.Drawing.Size(886, 377);
            this.second1.TabIndex = 23;
            this.second1.Visible = false;
            this.second1.Load += new System.EventHandler(this.second1_Load);
            // 
            // fourth1
            // 
            this.bunifuTransition1.SetDecoration(this.fourth1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.fourth1, BunifuAnimatorNS.DecorationType.None);
            this.fourth1.Location = new System.Drawing.Point(0, 58);
            this.fourth1.Name = "fourth1";
            this.fourth1.Size = new System.Drawing.Size(886, 377);
            this.fourth1.TabIndex = 22;
            this.fourth1.Visible = false;
            this.fourth1.Load += new System.EventHandler(this.fourth1_Load);
            // 
            // frmMDIServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 512);
            this.Controls.Add(this.grad1);
            this.Controls.Add(this.first1);
            this.Controls.Add(this.grad2);
            this.Controls.Add(this.third1);
            this.Controls.Add(this.second1);
            this.Controls.Add(this.fourth1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "frmMDIServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMDIServer";
            this.grad1.ResumeLayout(false);
            this.grad1.PerformLayout();
            this.grad2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private Grad grad1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Grad grad2;
        private UserControls.filedec fourth1;
        private UserControls.imgdec second1;
        private UserControls.steganimgdec third1;
        private UserControls.First first1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;

    }
}