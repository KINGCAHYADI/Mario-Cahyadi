namespace TAKEHOME_WEEK5
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_teamname = new System.Windows.Forms.TextBox();
            this.tb_country = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.tb_player = new System.Windows.Forms.TextBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.bt_remove = new System.Windows.Forms.Button();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.cb_team = new System.Windows.Forms.ComboBox();
            this.lb_pemain = new System.Windows.Forms.ListBox();
            this.bt_adt = new System.Windows.Forms.Button();
            this.bt_adp = new System.Windows.Forms.Button();
            this.tb_position = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soccer Team LIst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Country";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adding Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Choose Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adding PLayer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Team Country :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Team Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Team City :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 25);
            this.linkLabel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(689, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Player Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(677, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Player Number :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(668, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Player Position :";
            // 
            // tb_teamname
            // 
            this.tb_teamname.Location = new System.Drawing.Point(513, 59);
            this.tb_teamname.Name = "tb_teamname";
            this.tb_teamname.Size = new System.Drawing.Size(100, 31);
            this.tb_teamname.TabIndex = 12;
            // 
            // tb_country
            // 
            this.tb_country.Location = new System.Drawing.Point(513, 114);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(100, 31);
            this.tb_country.TabIndex = 13;
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(513, 169);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(100, 31);
            this.tb_city.TabIndex = 14;
            // 
            // tb_player
            // 
            this.tb_player.Location = new System.Drawing.Point(853, 66);
            this.tb_player.Name = "tb_player";
            this.tb_player.Size = new System.Drawing.Size(100, 31);
            this.tb_player.TabIndex = 15;
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(853, 122);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(100, 31);
            this.tb_number.TabIndex = 16;
            // 
            // bt_remove
            // 
            this.bt_remove.Location = new System.Drawing.Point(17, 552);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(135, 47);
            this.bt_remove.TabIndex = 18;
            this.bt_remove.Text = "REMOVE";
            this.bt_remove.UseVisualStyleBackColor = true;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // cb_country
            // 
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(194, 63);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(121, 33);
            this.cb_country.TabIndex = 19;
            this.cb_country.SelectedIndexChanged += new System.EventHandler(this.cb_country_SelectedIndexChanged);
            // 
            // cb_team
            // 
            this.cb_team.FormattingEnabled = true;
            this.cb_team.Location = new System.Drawing.Point(194, 111);
            this.cb_team.Name = "cb_team";
            this.cb_team.Size = new System.Drawing.Size(121, 33);
            this.cb_team.TabIndex = 20;
            this.cb_team.SelectedIndexChanged += new System.EventHandler(this.cb_team_SelectedIndexChanged);
            // 
            // lb_pemain
            // 
            this.lb_pemain.FormattingEnabled = true;
            this.lb_pemain.ItemHeight = 25;
            this.lb_pemain.Location = new System.Drawing.Point(32, 169);
            this.lb_pemain.Name = "lb_pemain";
            this.lb_pemain.Size = new System.Drawing.Size(283, 354);
            this.lb_pemain.TabIndex = 21;
            // 
            // bt_adt
            // 
            this.bt_adt.Location = new System.Drawing.Point(524, 221);
            this.bt_adt.Name = "bt_adt";
            this.bt_adt.Size = new System.Drawing.Size(89, 37);
            this.bt_adt.TabIndex = 22;
            this.bt_adt.Text = "ADD";
            this.bt_adt.UseVisualStyleBackColor = true;
            this.bt_adt.Click += new System.EventHandler(this.bt_adt_Click);
            // 
            // bt_adp
            // 
            this.bt_adp.Location = new System.Drawing.Point(992, 122);
            this.bt_adp.Name = "bt_adp";
            this.bt_adp.Size = new System.Drawing.Size(89, 37);
            this.bt_adp.TabIndex = 23;
            this.bt_adp.Text = "ADD";
            this.bt_adp.UseVisualStyleBackColor = true;
            this.bt_adp.Click += new System.EventHandler(this.bt_adp_Click);
            // 
            // tb_position
            // 
            this.tb_position.Location = new System.Drawing.Point(853, 169);
            this.tb_position.Name = "tb_position";
            this.tb_position.Size = new System.Drawing.Size(100, 31);
            this.tb_position.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(668, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "GK , FW , MF , DF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 674);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_position);
            this.Controls.Add(this.bt_adp);
            this.Controls.Add(this.bt_adt);
            this.Controls.Add(this.lb_pemain);
            this.Controls.Add(this.cb_team);
            this.Controls.Add(this.cb_country);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.tb_player);
            this.Controls.Add(this.tb_city);
            this.Controls.Add(this.tb_country);
            this.Controls.Add(this.tb_teamname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_teamname;
        private System.Windows.Forms.TextBox tb_country;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.TextBox tb_player;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.ComboBox cb_team;
        private System.Windows.Forms.ListBox lb_pemain;
        private System.Windows.Forms.Button bt_adt;
        private System.Windows.Forms.Button bt_adp;
        private System.Windows.Forms.TextBox tb_position;
        private System.Windows.Forms.Label label12;
    }
}

