using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Mario_W8
{
    public partial class playerdata : Form
    {
        MySqlConnection MySqlConnection;
        MySqlCommand MySqlCommand;
        MySqlDataAdapter MySqlDataAdapter;
        string query;
        string connection = "server=localhost;uid=root;pwd=;database=premier_league";
        DataTable teamname = new DataTable();
        DataTable playername= new DataTable();
        DataTable playerinfo= new DataTable();
        public playerdata()
        {
            InitializeComponent();
        }

        private void playerdata_Load(object sender, EventArgs e)
        {
            teamname = new DataTable();
            query = "select team_name from team;";
            MySqlConnection = new MySqlConnection(connection);
            MySqlCommand = new MySqlCommand(query, MySqlConnection);
            MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
            MySqlDataAdapter.Fill(teamname);
            comboBox_tim.DataSource = teamname;
            comboBox_tim.DisplayMember = "team_name";
        }
        private void comboBox_tim_SelectedIndexChanged(object sender, EventArgs e)
        {
            playername= new DataTable();
            query = $"select p.player_name  as 'player'from player p,premier_league.team t where  t.team_name='{comboBox_tim.Text}' and p.team_id=t.team_id ;"; ;
            MySqlConnection = new MySqlConnection(connection);
            MySqlCommand = new MySqlCommand(query, MySqlConnection);
            MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
            MySqlDataAdapter.Fill(playername);
            comboBox_player.DataSource = playername;
            comboBox_player.DisplayMember = "player";
        }
        private void comboBox_player_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerinfo= new DataTable();
            query=$"select p.player_name,t.team_name,p.playing_pos,n.nation,p.team_number from player p,nationality n, team t where p.team_id=t.team_id  and n.nationality_id=p.nationality_id and t.team_name ='{comboBox_tim.Text}' and p.player_name='{comboBox_player.Text}';";
            MySqlConnection = new MySqlConnection(connection);
            MySqlCommand = new MySqlCommand(query, MySqlConnection);
            MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
            MySqlDataAdapter.Fill(playerinfo);
            lbl_player.Text = playerinfo.Rows[0][0].ToString();
            lbl_team.Text = playerinfo.Rows[0][1].ToString();
            lbl_position.Text = playerinfo.Rows[0][2].ToString();
            lbl_nation.Text = playerinfo.Rows[0][3].ToString();
            lbl_squad.Text = playerinfo.Rows[0][4].ToString();
            playerinfo = new DataTable();
            query = $"SELECT d.type FROM dmatch d,player p WHERE p.player_id=d.player_id AND p.player_name='{comboBox_player.Text}';";
            MySqlConnection = new MySqlConnection(connection);
            MySqlCommand = new MySqlCommand(query, MySqlConnection);
            MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
            MySqlDataAdapter.Fill(playerinfo);
            int y = 0;
            int r = 0;
            int g = 0;
            int p = 0;
            for(int i=0;i<playerinfo.Rows.Count;i++)
            {
                switch (playerinfo.Rows[i][0].ToString())
                {
                    case "CY":
                        y+=1;
                        break;
                    case "CR":
                        r += 1;
                        break;
                    case "GO":
                        g += 1;
                        break;
                    case "PM":
                        p += 1;
                        break;
                }
            }
            lbl_yellow.Text = y.ToString();
            lbl_red.Text = r.ToString();
            lbl_goal.Text = g.ToString();
            lbl_pen.Text = p.ToString();
        }
    }
}
