using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Mario_W12
{
    public partial class EditManager : Form
    {
        string Query = "";
        string click1 = "";
        string connectionString = "server=localhost;uid=root;pwd=root;database=premier_league";
        MySqlConnection Connection;
        MySqlCommand Command;
        MySqlDataAdapter DataAdapter;
        MySqlDataReader DataReader;
        DataTable dt = new DataTable();
        DataTable dtmanagerteam= new DataTable();
        public EditManager()
        {
            Connection = new MySqlConnection(connectionString);
            InitializeComponent();
        }

        private void EditManager_Load(object sender, EventArgs e)
        {
            dt=new DataTable();
            Query = "select team_name name, team_id id from team ;";
            Command= new MySqlCommand(Query,Connection);
            DataAdapter = new MySqlDataAdapter(Command);
            DataAdapter.Fill(dt);
            comboBox_teamname.DataSource= dt;
            comboBox_teamname.DisplayMember= "name";
            comboBox_teamname.ValueMember = "id";
            DGVNotWorking();
        }
        private void DGVTeam()
        {
            dtmanagerteam = new DataTable();
            Query = $"select m.manager_name,t.team_name,birthdate,nation from team t join manager m on t.manager_id=m.manager_id join nationality n on m.nationality_id=n.nationality_id where t.team_name='{comboBox_teamname.Text}';";
            Command = new MySqlCommand(Query,Connection);
            DataAdapter = new MySqlDataAdapter(Command);
            DataAdapter.Fill(dtmanagerteam);
            dataGridView1.DataSource= dtmanagerteam;
        }
        private void DGVNotWorking()
        {
            dt = new DataTable();
            Query = $"select manager_name,nation,birthdate from manager m join nationality n on m.nationality_id=n.nationality_id where working=0;";
            Command = new MySqlCommand(Query, Connection);
            DataAdapter = new MySqlDataAdapter(Command);
            DataAdapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void comboBox_teamname_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGVTeam();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string currentmanager = dtmanagerteam.Rows[0][0].ToString();
            dt=new DataTable();
            Query= $"select manager_id from manager where manager_name='{click1}';";
            Command= new MySqlCommand(Query,Connection);
            DataAdapter= new MySqlDataAdapter(Command);
            DataAdapter.Fill(dt);
           
            
            if(click1 == "")
            {
                MessageBox.Show("Pilih terlebih dahulu");
            }
            else
            {
                string id = dt.Rows[0][0].ToString();
                //yg kerja jadi ga kerja
                Query = $"update manager set working=0 where manager_name='{currentmanager}';";
                Connection.Open();
                Command = new MySqlCommand(Query, Connection);
                DataReader = Command.ExecuteReader();
                Connection.Close();
                //yg g kerja jadi kerja
                Query = $"update team t, manager m set t.manager_id='{id}',m.working=1 where m.manager_id='{id}' and t.team_name='{comboBox_teamname.Text}'";
                Connection.Open();
                Command = new MySqlCommand(Query, Connection);
                DataReader = Command.ExecuteReader();
                Connection.Close();
                DGVTeam();
                DGVNotWorking();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            click1=dataGridView2.CurrentCell.Value.ToString();
        }
    }
}
