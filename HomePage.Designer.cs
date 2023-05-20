namespace OOP_Project_HOR
{
    partial class HomePage
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
            this.addpro_LL = new System.Windows.Forms.LinkLabel();
            this.profile_LL = new System.Windows.Forms.LinkLabel();
            this.search_button = new System.Windows.Forms.Button();
            this.logout_linkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // addpro_LL
            // 
            this.addpro_LL.AutoSize = true;
            this.addpro_LL.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.addpro_LL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpro_LL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.addpro_LL.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.addpro_LL.Location = new System.Drawing.Point(53, 44);
            this.addpro_LL.Name = "addpro_LL";
            this.addpro_LL.Size = new System.Drawing.Size(150, 25);
            this.addpro_LL.TabIndex = 3;
            this.addpro_LL.TabStop = true;
            this.addpro_LL.Text = "Add Property";
            this.addpro_LL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // profile_LL
            // 
            this.profile_LL.AutoSize = true;
            this.profile_LL.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.profile_LL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_LL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.profile_LL.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.profile_LL.Location = new System.Drawing.Point(217, 44);
            this.profile_LL.Name = "profile_LL";
            this.profile_LL.Size = new System.Drawing.Size(78, 25);
            this.profile_LL.TabIndex = 5;
            this.profile_LL.TabStop = true;
            this.profile_LL.Text = "Profile";
            this.profile_LL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_button.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.search_button.Location = new System.Drawing.Point(167, 604);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(222, 61);
            this.search_button.TabIndex = 12;
            this.search_button.Text = "Find now!!";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // logout_linkLabel
            // 
            this.logout_linkLabel.AutoSize = true;
            this.logout_linkLabel.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.logout_linkLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_linkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.logout_linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.logout_linkLabel.Location = new System.Drawing.Point(331, 44);
            this.logout_linkLabel.Name = "logout_linkLabel";
            this.logout_linkLabel.Size = new System.Drawing.Size(96, 25);
            this.logout_linkLabel.TabIndex = 13;
            this.logout_linkLabel.TabStop = true;
            this.logout_linkLabel.Text = "Log Out";
            this.logout_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_linkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_Project_HOR.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(651, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(767, 557);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOP_Project_HOR.Properties.Resources.Cross;
            this.pictureBox2.Location = new System.Drawing.Point(1414, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(52, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Write something about House of The Rent";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1462, 713);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logout_linkLabel);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.profile_LL);
            this.Controls.Add(this.addpro_LL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel addpro_LL;
        private System.Windows.Forms.LinkLabel profile_LL;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.LinkLabel logout_linkLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}