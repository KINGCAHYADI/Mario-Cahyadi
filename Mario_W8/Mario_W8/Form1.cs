using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario_W8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            panel_Container.Controls.Clear();
            playerdata playerdata_= new playerdata();
            playerdata_.Dock= DockStyle.Fill;
            playerdata_.TopLevel = false;
            playerdata_.ControlBox = false;
            playerdata_.FormBorderStyle= FormBorderStyle.None;
            this.panel_Container.Controls.Add(playerdata_);
            playerdata_.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            panel_Container.Controls.Clear();
            matchdetail matchdetail_ = new matchdetail();
            matchdetail_.Dock = DockStyle.Fill; 
            matchdetail_.TopLevel = false;
            matchdetail_.ControlBox = false;
            matchdetail_.FormBorderStyle= FormBorderStyle.None;
            this.panel_Container.Controls.Add(matchdetail_);
            matchdetail_.Show();
        }
    }
}
