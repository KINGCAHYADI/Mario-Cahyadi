using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario_W12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AddPlayer addPlayer= new AddPlayer();
            addPlayer.MdiParent= this;
            addPlayer.Dock = DockStyle.Fill;
            addPlayer.TopLevel = false;
            addPlayer.ControlBox = false;
            addPlayer.FormBorderStyle = FormBorderStyle.None;
            addPlayer.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            EditManager editManager= new EditManager();
            editManager.MdiParent = this;
            editManager.Dock = DockStyle.Fill;
            editManager.TopLevel = false;
            editManager.ControlBox = false;
            editManager.FormBorderStyle = FormBorderStyle.None;
            editManager.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            RemovePlayer removePlayer = new RemovePlayer();
            removePlayer.MdiParent = this;
            removePlayer.Dock = DockStyle.Fill;
            removePlayer.TopLevel = false;
            removePlayer.ControlBox = false;
            removePlayer.FormBorderStyle = FormBorderStyle.None;
            removePlayer.Show();
        }
    }
}
