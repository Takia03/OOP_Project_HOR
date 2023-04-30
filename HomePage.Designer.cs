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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addpro_LL = new System.Windows.Forms.LinkLabel();
            this.profile_LL = new System.Windows.Forms.LinkLabel();
            this.loca_CB = new System.Windows.Forms.ComboBox();
            this.Area_CB = new System.Windows.Forms.ComboBox();
            this.search_button = new System.Windows.Forms.Button();
            this.logout_linkLabel = new System.Windows.Forms.LinkLabel();
            this.Price_L = new System.Windows.Forms.Label();
            this.Min_TB = new System.Windows.Forms.TextBox();
            this.Max_TB = new System.Windows.Forms.TextBox();
            this.Min_L = new System.Windows.Forms.Label();
            this.Max_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Location = new System.Drawing.Point(461, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 711);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(48, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search Properties           ";
            // 
            // addpro_LL
            // 
            this.addpro_LL.AutoSize = true;
            this.addpro_LL.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpro_LL.LinkColor = System.Drawing.Color.Black;
            this.addpro_LL.Location = new System.Drawing.Point(53, 44);
            this.addpro_LL.Name = "addpro_LL";
            this.addpro_LL.Size = new System.Drawing.Size(109, 19);
            this.addpro_LL.TabIndex = 3;
            this.addpro_LL.TabStop = true;
            this.addpro_LL.Text = "Add Property";
            this.addpro_LL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // profile_LL
            // 
            this.profile_LL.AutoSize = true;
            this.profile_LL.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_LL.LinkColor = System.Drawing.Color.Black;
            this.profile_LL.Location = new System.Drawing.Point(207, 44);
            this.profile_LL.Name = "profile_LL";
            this.profile_LL.Size = new System.Drawing.Size(62, 19);
            this.profile_LL.TabIndex = 5;
            this.profile_LL.TabStop = true;
            this.profile_LL.Text = "Profile";
            this.profile_LL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // loca_CB
            // 
            this.loca_CB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loca_CB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loca_CB.FormattingEnabled = true;
            this.loca_CB.Location = new System.Drawing.Point(95, 249);
            this.loca_CB.Name = "loca_CB";
            this.loca_CB.Size = new System.Drawing.Size(259, 33);
            this.loca_CB.TabIndex = 6;
            this.loca_CB.Text = "Location";
            // 
            // Area_CB
            // 
            this.Area_CB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Area_CB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area_CB.FormattingEnabled = true;
            this.Area_CB.Location = new System.Drawing.Point(95, 315);
            this.Area_CB.Name = "Area_CB";
            this.Area_CB.Size = new System.Drawing.Size(259, 33);
            this.Area_CB.TabIndex = 10;
            this.Area_CB.Text = "Area(Sqft)";
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.DarkGray;
            this.search_button.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(109, 604);
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
            this.logout_linkLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_linkLabel.LinkColor = System.Drawing.Color.Black;
            this.logout_linkLabel.Location = new System.Drawing.Point(331, 44);
            this.logout_linkLabel.Name = "logout_linkLabel";
            this.logout_linkLabel.Size = new System.Drawing.Size(70, 19);
            this.logout_linkLabel.TabIndex = 13;
            this.logout_linkLabel.TabStop = true;
            this.logout_linkLabel.Text = "Log Out";
            this.logout_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_linkLabel_LinkClicked);
            // 
            // Price_L
            // 
            this.Price_L.AutoSize = true;
            this.Price_L.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Price_L.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_L.Location = new System.Drawing.Point(102, 383);
            this.Price_L.Name = "Price_L";
            this.Price_L.Size = new System.Drawing.Size(229, 32);
            this.Price_L.TabIndex = 14;
            this.Price_L.Text = "Price(BDT)           ";
            // 
            // Min_TB
            // 
            this.Min_TB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Min_TB.Location = new System.Drawing.Point(95, 492);
            this.Min_TB.Name = "Min_TB";
            this.Min_TB.Size = new System.Drawing.Size(111, 22);
            this.Min_TB.TabIndex = 15;
            // 
            // Max_TB
            // 
            this.Max_TB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Max_TB.Location = new System.Drawing.Point(239, 492);
            this.Max_TB.Name = "Max_TB";
            this.Max_TB.Size = new System.Drawing.Size(115, 22);
            this.Max_TB.TabIndex = 16;
            // 
            // Min_L
            // 
            this.Min_L.AutoSize = true;
            this.Min_L.BackColor = System.Drawing.Color.White;
            this.Min_L.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_L.Location = new System.Drawing.Point(91, 462);
            this.Min_L.Name = "Min_L";
            this.Min_L.Size = new System.Drawing.Size(74, 19);
            this.Min_L.TabIndex = 17;
            this.Min_L.Text = "Min :      ";
            // 
            // Max_L
            // 
            this.Max_L.AutoSize = true;
            this.Max_L.BackColor = System.Drawing.Color.White;
            this.Max_L.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max_L.Location = new System.Drawing.Point(236, 462);
            this.Max_L.Name = "Max_L";
            this.Max_L.Size = new System.Drawing.Size(63, 17);
            this.Max_L.TabIndex = 15;
            this.Max_L.Text = "Max :    ";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1462, 713);
            this.Controls.Add(this.Max_L);
            this.Controls.Add(this.Min_L);
            this.Controls.Add(this.Max_TB);
            this.Controls.Add(this.Min_TB);
            this.Controls.Add(this.Price_L);
            this.Controls.Add(this.logout_linkLabel);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.Area_CB);
            this.Controls.Add(this.loca_CB);
            this.Controls.Add(this.profile_LL);
            this.Controls.Add(this.addpro_LL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel addpro_LL;
        private System.Windows.Forms.LinkLabel profile_LL;
        private System.Windows.Forms.ComboBox loca_CB;
        private System.Windows.Forms.ComboBox Area_CB;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.LinkLabel logout_linkLabel;
        private System.Windows.Forms.Label Price_L;
        private System.Windows.Forms.TextBox Min_TB;
        private System.Windows.Forms.TextBox Max_TB;
        private System.Windows.Forms.Label Min_L;
        private System.Windows.Forms.Label Max_L;
    }
}