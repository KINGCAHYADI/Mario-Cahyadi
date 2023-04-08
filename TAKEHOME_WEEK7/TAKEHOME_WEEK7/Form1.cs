using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAKEHOME_WEEK7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int tb = Convert.ToInt32(tb_1.Text);
                if (tb < 1)
                {
                    MessageBox.Show("SALAH!");
                }
                else
                {
                    Form2 a = new Form2(Convert.ToInt32(tb_1.Text));
                    a.ShowDialog();
                
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
