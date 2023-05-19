namespace OOP_Project_HOR
{
    partial class owner_user_page
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_rented = new System.Windows.Forms.Button();
            this.button_to_let = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(531, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Profile";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(157, 251);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1109, 276);
            this.listBox1.TabIndex = 1;
            // 
            // button_rented
            // 
            this.button_rented.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.button_rented.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_rented.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rented.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.button_rented.Location = new System.Drawing.Point(416, 568);
            this.button_rented.Name = "button_rented";
            this.button_rented.Size = new System.Drawing.Size(174, 50);
            this.button_rented.TabIndex = 2;
            this.button_rented.Text = "Rented";
            this.button_rented.UseVisualStyleBackColor = false;
            // 
            // button_to_let
            // 
            this.button_to_let.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.button_to_let.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_to_let.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_to_let.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.button_to_let.Location = new System.Drawing.Point(846, 568);
            this.button_to_let.Name = "button_to_let";
            this.button_to_let.Size = new System.Drawing.Size(174, 50);
            this.button_to_let.TabIndex = 3;
            this.button_to_let.Text = "To-Let";
            this.button_to_let.UseVisualStyleBackColor = false;
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_home.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.button_home.Location = new System.Drawing.Point(1178, 660);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(174, 50);
            this.button_home.TabIndex = 5;
            this.button_home.Text = "home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOP_Project_HOR.Properties.Resources.Cross;
            this.pictureBox2.Location = new System.Drawing.Point(1328, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // owner_user_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1444, 736);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.button_to_let);
            this.Controls.Add(this.button_rented);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "owner_user_page";
            this.Text = "owner_user_page";
            this.Load += new System.EventHandler(this.owner_user_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_rented;
        private System.Windows.Forms.Button button_to_let;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}