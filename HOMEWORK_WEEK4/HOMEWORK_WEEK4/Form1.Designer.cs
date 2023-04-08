namespace HOMEWORK_WEEK4
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
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.cb_1 = new System.Windows.Forms.CheckBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(109, 49);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(100, 31);
            this.tb_1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAMA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "My favorite artist :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(212, 99);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(100, 31);
            this.tb_2.TabIndex = 3;
            // 
            // cb_1
            // 
            this.cb_1.AutoSize = true;
            this.cb_1.Location = new System.Drawing.Point(12, 154);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(423, 29);
            this.cb_1.TabIndex = 4;
            this.cb_1.Text = "All of the content i put in the box is true!";
            this.cb_1.UseVisualStyleBackColor = true;
            this.cb_1.CheckedChanged += new System.EventHandler(this.cb_1_CheckedChanged);
            // 
            // btn_1
            // 
            this.btn_1.Enabled = false;
            this.btn_1.Location = new System.Drawing.Point(338, 189);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(97, 39);
            this.btn_1.TabIndex = 5;
            this.btn_1.Text = "Submit";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_3
            // 
            this.btn_3.Enabled = false;
            this.btn_3.Location = new System.Drawing.Point(636, 383);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(174, 42);
            this.btn_3.TabIndex = 6;
            this.btn_3.Text = "NEXT FORM";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 437);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.cb_1);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.CheckBox cb_1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_3;
    }
}

