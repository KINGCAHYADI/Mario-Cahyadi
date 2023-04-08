using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAKEHOME_WEEK7
{
    public partial class Form2 : Form
    {
        Button[,] btn;
        int nomor = 0;
        int baris = 0;
        List<string> list = new List<string>();
        string jawaban = "";
        string simpan = "";
        string[] split;
        

        public Form2(int pindah)
        {
            InitializeComponent();
            nomor = pindah;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            btn = new Button[nomor, 5];
            for (int i = 0; i < nomor; i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    btn[i, x] = new Button();
                    btn[i, x].Location = new Point(20 + (x * 40), 20 + (i * 40));
                    btn[i, x].Size = new Size(40, 40);
                    this.Controls.Add(btn[i, x]);
                }
            }

            string file = "Wordle Word List.txt";
            string wordLines = File.ReadAllText(@"C:\Users\kingg\source\repos\TAKEHOME_WEEK7\TAKEHOME_WEEK7\bin\Wordle Word List.txt");
            split = wordLines.Split(',');
            jawaban = split[new Random().Next(1493)].ToUpper();
            MessageBox.Show(jawaban + " ");
            
        }
        private void click(object sender, EventArgs e)
        {
            Button sayang = (Button)sender;

            for (int y = 0; y < 5; y++)
            {
                if (btn[baris, y].Text == "")
                {
                    btn[baris, y].Text = sayang.Text;
                    simpan = simpan + sayang.Text;
                    break;
                }

            }

        }

        private void bt_enter_Click(object sender, EventArgs e)
        {
            bool check = false;
            int menang = 0;
            foreach (string a in split) 
            {
               
                if (a.ToUpper() == simpan )
                {

                check = true;
                }
            }
            if (check == false)
            {
                MessageBox.Show(simpan + " NOT IN THE WORDS LIST");
            }
            else 
            {

                for (int o = 0; o < 5; o++)
                {
                    if (simpan[o] == jawaban[o])
                    {
                        btn[baris, o].BackColor = Color.Green;
                        menang++;
                    }
                    else if (jawaban.Contains(simpan[o]))
                    {
                        btn[baris,o].BackColor = Color.Yellow; 
                    }
                }
                
                simpan = "";
                baris++;
            }
            if (menang == 5)
            {
                MessageBox.Show("WIN CK");
            }
            else if (baris == nomor)
            {
                MessageBox.Show("YOU LOSE,YOUR WORDS IS "+jawaban);
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            simpan = "";
            for (int k = 4; k >= 0; k--)
            {               
                if (btn[baris, k].Text != "")
                {
                    btn[baris, k].Text = "";
                    break;
                }
            }
            for (int u = 0; u < 5; u++)          
            { 
            if (btn[baris, u].Text != "")
                {
                    simpan = simpan + btn[baris,u].Text;
                }
            }
        }
    }
}
