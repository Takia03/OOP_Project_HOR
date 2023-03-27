namespace OOP_Project_HOR
{
    partial class add_property
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.rent_textBox = new System.Windows.Forms.TextBox();
            this.loc_textBox = new System.Windows.Forms.TextBox();
            this.city_textBox = new System.Windows.Forms.TextBox();
            this.room_comboBox = new System.Windows.Forms.ComboBox();
            this.bal_comboBox = new System.Windows.Forms.ComboBox();
            this.mas_comboBox = new System.Windows.Forms.ComboBox();
            this.bath_comboBox = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FlatSize_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_Project_HOR.Properties.Resources.o;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1491, 819);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(546, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD PROPERTY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name                     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rent                       :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description            :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "Location                :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 35);
            this.label6.TabIndex = 6;
            this.label6.Text = "City                       :";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(474, 139);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(319, 30);
            this.name_textBox.TabIndex = 7;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // rent_textBox
            // 
            this.rent_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rent_textBox.Location = new System.Drawing.Point(474, 511);
            this.rent_textBox.Name = "rent_textBox";
            this.rent_textBox.Size = new System.Drawing.Size(319, 30);
            this.rent_textBox.TabIndex = 8;
            // 
            // loc_textBox
            // 
            this.loc_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc_textBox.Location = new System.Drawing.Point(474, 270);
            this.loc_textBox.Name = "loc_textBox";
            this.loc_textBox.Size = new System.Drawing.Size(319, 30);
            this.loc_textBox.TabIndex = 9;
            // 
            // city_textBox
            // 
            this.city_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_textBox.Location = new System.Drawing.Point(474, 207);
            this.city_textBox.Name = "city_textBox";
            this.city_textBox.Size = new System.Drawing.Size(319, 30);
            this.city_textBox.TabIndex = 10;
            // 
            // room_comboBox
            // 
            this.room_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_comboBox.FormattingEnabled = true;
            this.room_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.room_comboBox.Location = new System.Drawing.Point(474, 322);
            this.room_comboBox.Name = "room_comboBox";
            this.room_comboBox.Size = new System.Drawing.Size(135, 31);
            this.room_comboBox.TabIndex = 11;
            this.room_comboBox.Text = " Room";
            // 
            // bal_comboBox
            // 
            this.bal_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bal_comboBox.FormattingEnabled = true;
            this.bal_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.bal_comboBox.Location = new System.Drawing.Point(655, 378);
            this.bal_comboBox.Name = "bal_comboBox";
            this.bal_comboBox.Size = new System.Drawing.Size(138, 31);
            this.bal_comboBox.TabIndex = 13;
            this.bal_comboBox.Text = "Balcony";
            // 
            // mas_comboBox
            // 
            this.mas_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mas_comboBox.FormattingEnabled = true;
            this.mas_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.mas_comboBox.Location = new System.Drawing.Point(655, 322);
            this.mas_comboBox.Name = "mas_comboBox";
            this.mas_comboBox.Size = new System.Drawing.Size(138, 31);
            this.mas_comboBox.TabIndex = 14;
            this.mas_comboBox.Text = "Master Bed";
            // 
            // bath_comboBox
            // 
            this.bath_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bath_comboBox.FormattingEnabled = true;
            this.bath_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.bath_comboBox.Location = new System.Drawing.Point(474, 378);
            this.bath_comboBox.Name = "bath_comboBox";
            this.bath_comboBox.Size = new System.Drawing.Size(135, 31);
            this.bath_comboBox.TabIndex = 15;
            this.bath_comboBox.Text = " Bathroom";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.Navy;
            this.add_button.Location = new System.Drawing.Point(644, 566);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(149, 56);
            this.add_button.TabIndex = 16;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = false;
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home_button.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.ForeColor = System.Drawing.Color.Navy;
            this.home_button.Location = new System.Drawing.Point(1186, 653);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(130, 48);
            this.home_button.TabIndex = 17;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 35);
            this.label7.TabIndex = 18;
            this.label7.Text = "Flat Size                 :";
            // 
            // FlatSize_textBox
            // 
            this.FlatSize_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatSize_textBox.Location = new System.Drawing.Point(474, 451);
            this.FlatSize_textBox.Name = "FlatSize_textBox";
            this.FlatSize_textBox.Size = new System.Drawing.Size(319, 30);
            this.FlatSize_textBox.TabIndex = 19;
            // 
            // add_property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1462, 713);
            this.Controls.Add(this.FlatSize_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.bath_comboBox);
            this.Controls.Add(this.mas_comboBox);
            this.Controls.Add(this.bal_comboBox);
            this.Controls.Add(this.room_comboBox);
            this.Controls.Add(this.city_textBox);
            this.Controls.Add(this.loc_textBox);
            this.Controls.Add(this.rent_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "add_property";
            this.Text = "add_property";
            this.Load += new System.EventHandler(this.add_property_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox rent_textBox;
        private System.Windows.Forms.TextBox loc_textBox;
        private System.Windows.Forms.TextBox city_textBox;
        private System.Windows.Forms.ComboBox room_comboBox;
        private System.Windows.Forms.ComboBox bal_comboBox;
        private System.Windows.Forms.ComboBox mas_comboBox;
        private System.Windows.Forms.ComboBox bath_comboBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FlatSize_textBox;
    }
}