namespace OOP_Project_HOR
{
    partial class show_property_details
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
            this.details_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listBox_show_property_details = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_back_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // details_label
            // 
            this.details_label.AutoSize = true;
            this.details_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.details_label.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.details_label.Location = new System.Drawing.Point(544, 50);
            this.details_label.Name = "details_label";
            this.details_label.Size = new System.Drawing.Size(295, 53);
            this.details_label.TabIndex = 0;
            this.details_label.Text = "Show  Details";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOP_Project_HOR.Properties.Resources.Cross;
            this.pictureBox2.Location = new System.Drawing.Point(1349, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // listBox_show_property_details
            // 
            this.listBox_show_property_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.listBox_show_property_details.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_show_property_details.FormattingEnabled = true;
            this.listBox_show_property_details.ItemHeight = 23;
            this.listBox_show_property_details.Location = new System.Drawing.Point(189, 218);
            this.listBox_show_property_details.Name = "listBox_show_property_details";
            this.listBox_show_property_details.Size = new System.Drawing.Size(1031, 372);
            this.listBox_show_property_details.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.button1.Location = new System.Drawing.Point(960, 659);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 52);
            this.button1.TabIndex = 40;
            this.button1.Text = "Send Request";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_back_search
            // 
            this.button_back_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button_back_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back_search.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.button_back_search.Location = new System.Drawing.Point(189, 644);
            this.button_back_search.Name = "button_back_search";
            this.button_back_search.Size = new System.Drawing.Size(260, 52);
            this.button_back_search.TabIndex = 41;
            this.button_back_search.Text = "Back";
            this.button_back_search.UseVisualStyleBackColor = false;
            this.button_back_search.Click += new System.EventHandler(this.button_back_search_Click);
            // 
            // show_property_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1444, 736);
            this.Controls.Add(this.button_back_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_show_property_details);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.details_label);
            this.Name = "show_property_details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label details_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox_show_property_details;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_back_search;
    }
}