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
    public partial class Form1 : Form
    {
        public static string nama = "";
        public static string artis = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (tb_1.Text == "" || tb_2.Text == "")
            {
                MessageBox.Show("ERROR LOLLLL");
            }
            else
            {
                btn_3.Enabled = true;
            }

        }

        private void cb_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_1.Checked)
            {
                btn_1.Enabled = true;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            nama = tb_1.Text;
            artis = tb_2.Text;

            new Form2().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
