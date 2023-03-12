namespace TAKEHOME_WEEK3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namaku = tb_nama.Text;
            string emailku = tb_email.Text;
            int umur = Convert.ToInt32(tb_umur.Text);
            string nomerhp = tb_hp.Text;
            string dewasa;

            if (umur < 18)
            { MessageBox.Show("NAME :" + namaku + Environment.NewLine + " EMAILKU :" + emailku + Environment.NewLine + " AKU ADALAH : MINOR" + Environment.NewLine + "NOMOR HPKU :" + nomerhp); }
            else if (umur > 18)
            { MessageBox.Show("NAME :" + namaku + Environment.NewLine + " EMAILKU :" + emailku + Environment.NewLine + " AKU ADALAH : ADULT" + Environment.NewLine + "NOMOR HPKU :" + nomerhp); }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            tb_nama.Clear();
            tb_email.Clear();
            tb_umur.Clear();
            tb_hp.Clear();
        }
    }
}