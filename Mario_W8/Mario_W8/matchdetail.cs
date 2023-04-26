using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Mario_W8
{
    public partial class matchdetail : Form
    {
        MySqlConnection MySqlConnection;
        MySqlCommand MySqlCommand;
        MySqlDataAdapter MySqlDataAdapter;
        string query;
        string connection = "server=localhost;uid=root;pwd=;database=premier_league";
        DataTable teamname = new DataTable();
        DataTable date = new DataTable();
        DataTable playerinfo= new DataTable();
        public matchdetail()
        {
            InitializeComponent();
        }

        private void matchdetail_Load(object sender, EventArgs e)
        {
            teamname = new DataTable();
            query = "select team_name from team;";
            MySqlConnection = new MySqlConnection(connection);
            MySqlCommand = new MySqlCommand(query, MySqlConnection);
            MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
            MySqlDataAdapter.Fill(teamname);
            //dataGridView1.DataSource = teamname;
            comboBox_tim.DataSource = teamname;
            comboBox_tim.DisplayMember = "team_name";
        }

        private void comboBox_tim_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            date = new DataTable();
            query = $"SELECT m.match_date as 'tanggal',m.match_id as'ID' FROM team t1,team t2, premier_league.match m\r\nWHERE (t1.team_name='{comboBox_tim.Text}' or t2.team_name='{comboBox_tim.Text}') \r\nAND t1.team_id=m.team_home AND t2.team_id=m.team_away;";
            MySqlConnection = new MySqlConnection(connection);
            MySqlCommand = new MySqlCommand(query, MySqlConnection);
            MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
            MySqlDataAdapter.Fill(date);
            //dataGridView1.DataSource = date;
            comboBox_date.DataSource = date;
            comboBox_date.DisplayMember = "tanggal";
            comboBox_date.ValueMember= "ID";
        }

        private void comboBox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerinfo=new DataTable();
            query = $"select t1.team_name as 't1', t2.team_name as 't2' from premier_league.match m, team t1, team t2 \r\nwhere m.team_home = t1.team_id and m.team_away = t2.team_id and m.match_id = '{comboBox_date.SelectedValue.ToString()}';";
            MySqlCommand = new MySqlCommand(query, MySqlConnection);
            MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
            MySqlDataAdapter.Fill(playerinfo);
            label1.Text = playerinfo.Rows[0][0].ToString();
            label2.Text = playerinfo.Rows[0][1].ToString();
            playerinfo = new DataTable();
            query = $"select t.team_name, p.player_name,p.playing_pos as'position'\r\nfrom player p, team t where p.team_id=t.team_id and (t.team_name='{label1.Text}' or t.team_name='{label2.Text}') order by 1;";
            MySqlConnection = new MySqlConnection(connection);
            MySqlCommand = new MySqlCommand(query, MySqlConnection);
            MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
            MySqlDataAdapter.Fill(playerinfo);
            dataGridView1.DataSource = playerinfo;
            playerinfo = new DataTable();
            query = $"SELECT d.minute as'minute',t.team_name as'team name',p.player_name as'player name',if(d.type='CY','Yellow Card',if(d.type='CR','Red Card',if(d.type='GO','Goal',if(d.type='GP','Goal Penalty',if(d.type='GW','Own GOal','Penalty Miss'))))) as 'type'\r\nFROM dmatch d,team t,player p\r\nWHERE d.team_id=t.team_id AND d.player_id=p.player_id AND d.match_id='{comboBox_date.SelectedValue.ToString()}';";
            MySqlConnection = new MySqlConnection(connection);
            MySqlCommand = new MySqlCommand(query, MySqlConnection);
            MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
            MySqlDataAdapter.Fill(playerinfo);
            dataGridView2.DataSource = playerinfo;
        }
    }
}
