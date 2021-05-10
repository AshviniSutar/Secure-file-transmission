namespace Finalproject
{
    partial class frmMDIClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIClient));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gradient1 = new Finalproject.Gradient();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.gradient2 = new Finalproject.Gradient();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lbllastlogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.firstUc1 = new Finalproject.UserControls.FirstUc();
            this.fourthuc1 = new Finalproject.UserControls.Fourthuc();
            this.seconduc1 = new Finalproject.UserControls.Seconduc();
            this.thirduc1 = new Finalproject.UserControls.Thirduc();
            this.gradient1.SuspendLayout();
            this.gradient2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition2.Cursor = null;
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
            this.bunifuTransition2.DefaultAnimation = animation1;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
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
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gradient1
            // 
            this.gradient1.BackColor = System.Drawing.Color.White;
            this.gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gradient1.ColorTop = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.button6);
            this.gradient1.Controls.Add(this.button7);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Controls.Add(this.button3);
            this.bunifuTransition1.SetDecoration(this.gradient1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.gradient1, BunifuAnimatorNS.DecorationType.None);
            this.gradient1.Location = new System.Drawing.Point(0, 2);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(902, 56);
            this.gradient1.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.button6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(760, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 56);
            this.button6.TabIndex = 2;
            this.button6.Text = "Help";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition2.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.button7.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(827, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 56);
            this.button7.TabIndex = 3;
            this.button7.Text = "Logout";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(673, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 56);
            this.button3.TabIndex = 1;
            this.button3.Text = "About us";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // gradient2
            // 
            this.gradient2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gradient2.ColorTop = System.Drawing.Color.Empty;
            this.gradient2.Controls.Add(this.lbllogin);
            this.gradient2.Controls.Add(this.lbllastlogin);
            this.gradient2.Controls.Add(this.button1);
            this.gradient2.Controls.Add(this.button5);
            this.gradient2.Controls.Add(this.button2);
            this.gradient2.Controls.Add(this.button4);
            this.bunifuTransition1.SetDecoration(this.gradient2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.gradient2, BunifuAnimatorNS.DecorationType.None);
            this.gradient2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradient2.Location = new System.Drawing.Point(0, 474);
            this.gradient2.Name = "gradient2";
            this.gradient2.Size = new System.Drawing.Size(902, 77);
            this.gradient2.TabIndex = 9;
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.lbllogin, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbllogin, BunifuAnimatorNS.DecorationType.None);
            this.lbllogin.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbllogin.Location = new System.Drawing.Point(545, 5);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(118, 28);
            this.lbllogin.TabIndex = 13;
            this.lbllogin.Text = "Login Time";
            // 
            // lbllastlogin
            // 
            this.lbllastlogin.AutoSize = true;
            this.lbllastlogin.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.lbllastlogin, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbllastlogin, BunifuAnimatorNS.DecorationType.None);
            this.lbllastlogin.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbllastlogin.Location = new System.Drawing.Point(545, 49);
            this.lbllastlogin.Name = "lbllastlogin";
            this.lbllastlogin.Size = new System.Drawing.Size(164, 28);
            this.lbllastlogin.TabIndex = 14;
            this.lbllastlogin.Text = "Last Login Time";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition2.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 80);
            this.button1.TabIndex = 9;
            this.button1.Text = "File_Encryption";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuTransition2.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(389, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 77);
            this.button5.TabIndex = 12;
            this.button5.Text = "Client";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuTransition2.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(150, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 80);
            this.button2.TabIndex = 10;
            this.button2.Text = "File embeding";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuTransition2.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(283, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 80);
            this.button4.TabIndex = 11;
            this.button4.Text = "Image Encryption";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // firstUc1
            // 
            this.firstUc1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstUc1.BackgroundImage")));
            this.firstUc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.firstUc1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.firstUc1, BunifuAnimatorNS.DecorationType.None);
            this.firstUc1.Location = new System.Drawing.Point(0, 55);
            this.firstUc1.Name = "firstUc1";
            this.firstUc1.Size = new System.Drawing.Size(903, 421);
            this.firstUc1.TabIndex = 8;
            // 
            // fourthuc1
            // 
            this.fourthuc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.fourthuc1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.fourthuc1, BunifuAnimatorNS.DecorationType.None);
            this.fourthuc1.Location = new System.Drawing.Point(0, 55);
            this.fourthuc1.Name = "fourthuc1";
            this.fourthuc1.Size = new System.Drawing.Size(903, 421);
            this.fourthuc1.TabIndex = 13;
            this.fourthuc1.Visible = false;
            // 
            // seconduc1
            // 
            this.bunifuTransition2.SetDecoration(this.seconduc1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.seconduc1, BunifuAnimatorNS.DecorationType.None);
            this.seconduc1.Location = new System.Drawing.Point(0, 55);
            this.seconduc1.Name = "seconduc1";
            this.seconduc1.Size = new System.Drawing.Size(903, 421);
            this.seconduc1.TabIndex = 10;
            this.seconduc1.Visible = false;
            // 
            // thirduc1
            // 
            this.bunifuTransition2.SetDecoration(this.thirduc1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.thirduc1, BunifuAnimatorNS.DecorationType.None);
            this.thirduc1.Location = new System.Drawing.Point(0, 55);
            this.thirduc1.Name = "thirduc1";
            this.thirduc1.Size = new System.Drawing.Size(903, 421);
            this.thirduc1.TabIndex = 11;
            this.thirduc1.Visible = false;
            // 
            // frmMDIClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 551);
            this.Controls.Add(this.gradient1);
            this.Controls.Add(this.gradient2);
            this.Controls.Add(this.firstUc1);
            this.Controls.Add(this.fourthuc1);
            this.Controls.Add(this.seconduc1);
            this.Controls.Add(this.thirduc1);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMDIClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmMDIClient";
            this.Load += new System.EventHandler(this.frmMDIClient_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.gradient2.ResumeLayout(false);
            this.gradient2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private UserControls.Seconduc seconduc1;
        private UserControls.Thirduc thirduc1;
        private UserControls.FirstUc firstUc1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private Gradient gradient1;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lbllastlogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private UserControls.Fourthuc fourthuc1;
        private Gradient gradient2;


    }
}