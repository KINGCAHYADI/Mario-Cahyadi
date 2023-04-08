using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOMEWORK_WEEK4
{
    public partial class Form2 : Form
        
    {
        public static int check = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void rb_7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "HI NAMAKU " + Form1.nama + ", AKU SUKA ARTIS YANG NAMANYA " + Form1.artis;
          

        }

        private void cb_2_CheckedChanged(object sender, EventArgs e)
        {
            check++;
            if (check == 2)
            {
                btn_2.Enabled = true;
            }

        }

        private void cb_3_CheckedChanged(object sender, EventArgs e)
        {
            check++;
            if (check == 2)
            {
                btn_2.Enabled = true;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (rb_1.Checked)
            { this.BackColor = Color.Red; }
            if (rb_2.Checked)
            { this.BackColor = Color.Green; }
            if (rb_3.Checked)
            { this.BackColor = Color.Yellow; }
            if (rb_4.Checked)
            { this.BackColor = Color.Blue; }
            if (rb_5.Checked)
            { this.BackColor = Color.Pink; }
            if (rb_6.Checked)
            { this.ForeColor = Color.Black; }
            if (rb_7.Checked)
            { this.ForeColor = Color.White; }
            if (rb_8.Checked)
            { this.ForeColor = Color.Purple; }
        }
    }
}
