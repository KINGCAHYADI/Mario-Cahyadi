using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Mario_W12
{
    public partial class RemovePlayer : Form
    {
        string Query = "";
        string click = "";
        string connectionString = "server=localhost;uid=root;pwd=root;database=premier_league";
        MySqlConnection Connection;
        MySqlCommand Command;
        MySqlDataAdapter DataAdapter;
        MySqlDataReader DataReader;
        DataTable dt = new DataTable();
        public RemovePlayer()
        {
            Connection = new MySqlConnection(connectionString);
            InitializeComponent();
        }

        private void RemovePlayer_Load(object sender, EventArgs e)
        {
            dt= new DataTable();
            Query = "select team_name name, team_id id from team ;";
            Command =new MySqlCommand(Query,Connection);
            DataAdapter=new MySqlDataAdapter(Command);
            DataAdapter.Fill(dt);
            comboBox_teamname.DataSource = dt;
            comboBox_teamname.DisplayMember= "name";
            comboBox_teamname.ValueMember= "id";
        }

        private void comboBox_teamname_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            Query = $"select p.player_name,p.nationality_id,p.playing_pos,p.team_number,p.height,p.weight,p.birthdate from player p, team t where p.team_id=t.team_id and p.status=1 and t.team_name='{comboBox_teamname.Text}';";
            Command = new MySqlCommand(Query, Connection);
            DataAdapter = new MySqlDataAdapter(Command);
            DataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            dt= new DataTable();
            Query=$"select count(p.player_name) from player p,team t where p.team_id = t.team_id  and status =1 and t.team_name ='{comboBox_teamname.Text}';";
            Command = new MySqlCommand(Query, Connection);
            DataAdapter = new MySqlDataAdapter(Command);
            DataAdapter.Fill(dt);
            int jumlah = Convert.ToInt32(dt.Rows[0][0]);
            
            if(string.IsNullOrEmpty(click))
            {
                MessageBox.Show("Choose first");
            }
            else if(jumlah <=11)
            {
                MessageBox.Show("minimal 11 pemain");
            }
            else
            {
                Query = $"update player set status=0 where player_name='{click}';";
                Connection.Open();
                Command = new MySqlCommand(Query, Connection);
                DataReader = Command.ExecuteReader();
                Connection.Close();
                dt = new DataTable();
                Query = $"select p.player_name,p.nationality_id,p.playing_pos,p.team_number,p.height,p.weight,p.birthdate from player p, team t where p.team_id=t.team_id and p.status=1 and t.team_name='{comboBox_teamname.Text}';";
                Command = new MySqlCommand(Query, Connection);
                DataAdapter = new MySqlDataAdapter(Command);
                DataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                click = "";
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            click = dataGridView1.CurrentCell.Value.ToString();
        }
    }
}
