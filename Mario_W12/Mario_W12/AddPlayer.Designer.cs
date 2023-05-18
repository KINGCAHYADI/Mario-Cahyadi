namespace Mario_W12
{
    partial class AddPlayer
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
            this.textBox_playerid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_playertoteam = new System.Windows.Forms.Button();
            this.comboBox_teamname = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_birthdate = new System.Windows.Forms.DateTimePicker();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_nationality = new System.Windows.Forms.ComboBox();
            this.textBox_position = new System.Windows.Forms.TextBox();
            this.textBox_teamnumber = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_playerid
            // 
            this.textBox_playerid.Location = new System.Drawing.Point(117, 12);
            this.textBox_playerid.Name = "textBox_playerid";
            this.textBox_playerid.Size = new System.Drawing.Size(100, 20);
            this.textBox_playerid.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Player ID";
            // 
            // btn_playertoteam
            // 
            this.btn_playertoteam.Location = new System.Drawing.Point(117, 338);
            this.btn_playertoteam.Name = "btn_playertoteam";
            this.btn_playertoteam.Size = new System.Drawing.Size(85, 23);
            this.btn_playertoteam.TabIndex = 36;
            this.btn_playertoteam.Text = "Add";
            this.btn_playertoteam.UseVisualStyleBackColor = true;
            this.btn_playertoteam.Click += new System.EventHandler(this.btn_playertoteam_Click);
            // 
            // comboBox_teamname
            // 
            this.comboBox_teamname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_teamname.FormattingEnabled = true;
            this.comboBox_teamname.Location = new System.Drawing.Point(117, 293);
            this.comboBox_teamname.Name = "comboBox_teamname";
            this.comboBox_teamname.Size = new System.Drawing.Size(121, 21);
            this.comboBox_teamname.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Team Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "BirthDate";
            // 
            // dateTimePicker_birthdate
            // 
            this.dateTimePicker_birthdate.Location = new System.Drawing.Point(117, 260);
            this.dateTimePicker_birthdate.Name = "dateTimePicker_birthdate";
            this.dateTimePicker_birthdate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_birthdate.TabIndex = 32;
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(117, 216);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(100, 20);
            this.textBox_weight.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Weight";
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(117, 182);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(100, 20);
            this.textBox_height.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Height";
            // 
            // comboBox_nationality
            // 
            this.comboBox_nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nationality.FormattingEnabled = true;
            this.comboBox_nationality.Location = new System.Drawing.Point(117, 114);
            this.comboBox_nationality.Name = "comboBox_nationality";
            this.comboBox_nationality.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nationality.TabIndex = 27;
            // 
            // textBox_position
            // 
            this.textBox_position.Location = new System.Drawing.Point(117, 148);
            this.textBox_position.Name = "textBox_position";
            this.textBox_position.Size = new System.Drawing.Size(100, 20);
            this.textBox_position.TabIndex = 26;
            // 
            // textBox_teamnumber
            // 
            this.textBox_teamnumber.Location = new System.Drawing.Point(117, 81);
            this.textBox_teamnumber.Name = "textBox_teamnumber";
            this.textBox_teamnumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_teamnumber.TabIndex = 25;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(117, 47);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nationality";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Team_Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Name";
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_playerid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_playertoteam);
            this.Controls.Add(this.comboBox_teamname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker_birthdate);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_nationality);
            this.Controls.Add(this.textBox_position);
            this.Controls.Add(this.textBox_teamnumber);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Name = "AddPlayer";
            this.Text = "AddPlayer";
            this.Load += new System.EventHandler(this.AddPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_playerid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_playertoteam;
        private System.Windows.Forms.ComboBox comboBox_teamname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthdate;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_nationality;
        private System.Windows.Forms.TextBox textBox_position;
        private System.Windows.Forms.TextBox textBox_teamnumber;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}