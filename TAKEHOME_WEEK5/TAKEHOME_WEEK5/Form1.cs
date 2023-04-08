using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TAKEHOME_WEEK5
{
    public partial class Form1 : Form
    {
        List<string> listpemain = new List<string>();
        List<string> listtim = new List<string>();
        List<string> listnegara = new List<string>();
        public class team
        {
            public string teamname { get; set; }
            public string teamcountry { get; set; }
            public string teamcity { get; set; }
        }
        public class player
        {
            public string playername { get; set; }
            public string teamnumber { get; set; }
            public string playerposition { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listtim.Add("Spain,Real Madrid");
            listpemain.Add("(01)" + "Thibaut Courtois" + "GK" + ";Real Madrid");
            listpemain.Add("(02)" + "Dani Carvajal" + "DF" + ";Real Madrid");
            listpemain.Add("(03)" + "Elder Militao" + "DF" + ";Real Madrid");
            listpemain.Add("(04)" + "David Alaba" + "DF" + ";Real Madrid");
            listpemain.Add("(05)" + "Jesus Vallejo" + "DF" + ";Real Madrid");
            listpemain.Add("(06)" + "Nacho" + "DF" + ";Real Madrid");
            listpemain.Add("(07)" + "Eden Hazard" + "FW" + ";Real Madrid");
            listpemain.Add("(08)" + "Toni Kroos" + "MW" + ";Real Madrid");
            listpemain.Add("(09)" + "Karim Benzema" + "FW" + ";Real Madrid");
            listpemain.Add("(10)" + "Luka Modric" + "MF" + ";Real Madrid");
            listpemain.Add("(11)" + "Marco Asensio" + "FW" + ";Real Madrid");


            listtim.Add("Spain,Atletico Madrid");
            listpemain.Add("(01)" + "Ivo Grbic" + "GK" + ";Atletico Madrid");
            listpemain.Add("(02)" + "Jose Gimenez" + "DF" + ";Atletico Madrid");
            listpemain.Add("(03)" + "Sergio Reguilon" + "DF" + ";Atletico Madrid");
            listpemain.Add("(04)" + "Geoffrey Kondogbia" + "MF" + ";Atletico Madrid");
            listpemain.Add("(05)" + "Rodrigo De Paul" + "MF" + ";Atletico Madrid");
            listpemain.Add("(06)" + "Koke" + "MF" + ";Atletico Madrid");
            listpemain.Add("(08)" + "Antonie Griezmann" + "FW" + ";Atletico Madrid");
            listpemain.Add("(10)" + "Angel Correa" + "FW" + ";Atletico Madrid");
            listpemain.Add("(11)" + "Thomas Lemar" + "MF" + ";Atletico Madrid");
            listpemain.Add("(12)" + "Matt Doherty" + "DF" + ";Atletico Madrid");


            listtim.Add("France,Paris saint germain");
            listpemain.Add("(02)" + "Achraf Hakimi" + "DF" + ";Paris Saint Germain");
            listpemain.Add("(03)" + "Presnel Kimpembe" + "DF" + ";Paris Saint Germain");
            listpemain.Add("(04)" + "Sergio Ramos" + "DF" + ";Paris Saint Germain");
            listpemain.Add("(05)" + "Marquinhos" + "DF" + ";Paris Saint Germain");
            listpemain.Add("(06)" + "Marco Verratti" + "MF" + ";Paris Saint Germain");
            listpemain.Add("(07)" + "Kylian Mbappe" + "FW" + ";Paris Saint Germain");
            listpemain.Add("(08)" + "Fabian Ruiz" + "MF" + ";Paris Saint Germain");
            listpemain.Add("(10)" + "Neymar" + "FW" + ";Paris Saint Germain");
            listpemain.Add("(14)" + "Juan Bernat" + "DF" + ";Paris Saint Germain");
            listpemain.Add("(15)" + "Danilo Pereira" + "MF" + ";Paris Saint Germain");
            listpemain.Add("(16)" + "Sergio Rico" + "GK" + ";Paris Saint Germain");

            cb_country.Items.Add("Spain");
            cb_country.Items.Add("France");
        }

        private void bt_adt_Click(object sender, EventArgs e)
        {
            if ((tb_teamname.Text=="") || (tb_country.Text=="") || (tb_city.Text==""))
            {
                MessageBox.Show("MASUKAN DATA TERLEBIH DAHULU");
            }
            else
            {
                int counter = 0;

                foreach (var teams in listtim.ToList())
                {
                    string[] nameteam = teams.Split(',');
                    if (nameteam[1] == tb_teamname.Text)
                    {
                        MessageBox.Show("TEAM SUDAH TERDAFTAR");
                        counter++;
                    }
                }
                if (cb_team.Items.Contains(tb_teamname) == false)
                {
                    if (cb_country.Items.Contains(tb_country) == false && counter == 0)
                    {
                        cb_country.Items.Add(tb_country.Text);
                        cb_team.Items.Add(tb_teamname.Text);
                        listtim.Add(tb_country.Text + "," + tb_teamname.Text);
                        counter++;

                    }
                    else if (cb_country.Items.Contains(tb_country) == true && counter == 0)
                    {
                        cb_team.Items.Add(tb_teamname.Text);
                        listtim.Add(tb_country.Text + "," + tb_teamname.Text);
                        counter++;

                    }
                }

            }

        }

        private void bt_adp_Click(object sender, EventArgs e)
        {
            {
                int counter = 0;
                if (tb_player.Text == "" || tb_position.Text == "" || tb_number.Text == "")
                {
                    MessageBox.Show("DATA BELUM DI ISI");
                }
                else
                {
                    string pilihtim = cb_team.SelectedItem.ToString();
                    foreach (string n in listpemain)
                    {
                        string[] pilihtimm = n.Split (';');
                        if (pilihtimm[1] == pilihtim)
                        {
                            if (pilihtimm[0] == "(" + tb_number.Text + ")" + " " + tb_player.Text + "," + tb_position.Text)
                            {
                                MessageBox.Show("NAMA PEMAINNYA DOBEL");
                                counter++;
                            }

                        }

                    }
                    if (counter == 0)
                    {
                        listpemain.Add("(" + tb_number.Text + ")" + " " + tb_player.Text + "," + tb_position.Text + ";" + pilihtim);
                        lb_pemain.Items.Add("(" + tb_number.Text + ")" + " " + tb_player.Text + "," + tb_position.Text);
                    }
                }
            }


        }

        private void cb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_pemain.Items.Clear();


            foreach (string n in listpemain)
            {
                string[] pilihtimm = n.Split(';');
                if (pilihtimm[1] == cb_team.SelectedItem.ToString())
                {
                    lb_pemain.Items.Add(pilihtimm[0]);
                }
            }

        }

        private void cb_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            {

            cb_team.Items.Clear();
                foreach (string n in listtim)
                {
                    string[] pisahtim = n.Split(',');
                    if (pisahtim[0] == cb_country.SelectedItem.ToString())
                    {
                        cb_team.Items.Add(pisahtim[1]);
                    }
                }
            }

        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            if (lb_pemain.Items.Count <= 11)
            {
                MessageBox.Show("PEMAIN MINIMAl 11,TIDAK BIDA DI KURANGIN LAGI");
            }
            else
            {
                lb_pemain.Items.Remove(lb_pemain.SelectedItem);
            }



        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
//r