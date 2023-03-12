namespace TAKEHOME_WEEK3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tb_nama = new TextBox();
            tb_umur = new TextBox();
            tb_email = new TextBox();
            tb_hp = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 42);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 0;
            label1.Text = "NAMA :";
            // 
            // tb_nama
            // 
            tb_nama.Location = new Point(200, 42);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(200, 39);
            tb_nama.TabIndex = 1;
            // 
            // tb_umur
            // 
            tb_umur.Location = new Point(200, 109);
            tb_umur.Name = "tb_umur";
            tb_umur.Size = new Size(200, 39);
            tb_umur.TabIndex = 2;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(200, 179);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(200, 39);
            tb_email.TabIndex = 3;
            // 
            // tb_hp
            // 
            tb_hp.Location = new Point(200, 246);
            tb_hp.Name = "tb_hp";
            tb_hp.Size = new Size(200, 39);
            tb_hp.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 109);
            label2.Name = "label2";
            label2.Size = new Size(69, 32);
            label2.TabIndex = 5;
            label2.Text = "AGE :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 179);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 6;
            label3.Text = "EMAIL :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 246);
            label4.Name = "label4";
            label4.Size = new Size(99, 32);
            label4.TabIndex = 7;
            label4.Text = "NO HP :";
            // 
            // button1
            // 
            button1.Location = new Point(526, 323);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 8;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(100, 323);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 9;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_hp);
            Controls.Add(tb_email);
            Controls.Add(tb_umur);
            Controls.Add(tb_nama);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_nama;
        private TextBox tb_umur;
        private TextBox tb_email;
        private TextBox tb_hp;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}