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
    public partial class AddPlayer : Form
    {
        string Query = "";
        string connectionString = "server=localhost;uid=root;pwd=root;database=premier_league";
        MySqlConnection Connection;
        MySqlCommand Command;
        MySqlDataAdapter DataAdapter;
        MySqlDataReader DataReader;
        DataTable dt= new DataTable();
        public AddPlayer()
        {
            Connection = new MySqlConnection(connectionString);
            InitializeComponent();
        }
        private void format(string query)
        {
            dt = new DataTable();
            Command = new MySqlCommand(query, Connection);
            DataAdapter = new MySqlDataAdapter(Command);
            DataAdapter.Fill(dt);
        }
        private void AddPlayer_Load(object sender, EventArgs e)
        {
            Query = "select nation n,nationality_id id from nationality n;";
            format(Query);
            comboBox_nationality.DataSource= dt;
            comboBox_nationality.DisplayMember= "n";
            comboBox_nationality.ValueMember= "id";
            Query = "select team_name name, team_id id from team t;";
            format(Query);
            comboBox_teamname.DataSource = dt;
            comboBox_teamname.DisplayMember = "name";
            comboBox_teamname.ValueMember = "id";
        }

        private void btn_playertoteam_Click(object sender, EventArgs e)
        {
            string playerid = textBox_playerid.Text;
            string name = textBox_name.Text;
            string teamnumber = textBox_teamnumber.Text;
            string nationality = comboBox_nationality.SelectedValue.ToString();
            string pos = textBox_position.Text;
            string height = textBox_height.Text;
            string weight = textBox_weight.Text;
            string birthdate = dateTimePicker_birthdate.Value.Date.ToString("yyyy-MM-dd");
            string teamname = comboBox_teamname.SelectedValue.ToString();

            Query = $"insert into player values ('{playerid}',{teamnumber},'{name}','{nationality}','{pos}',{height},{weight},'{birthdate}','{teamname}',1,0);";

            try
            {
                Connection.Open();
                Command = new MySqlCommand(Query, Connection);
                DataReader = Command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
                textBox_playerid.Clear();
                textBox_name.Clear() ;
                textBox_teamnumber.Clear() ;
                textBox_position.Clear() ;
                textBox_height.Clear() ;
                textBox_weight.Clear() ;
            }
        }

       
    }
}
