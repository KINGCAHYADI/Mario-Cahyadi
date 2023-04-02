using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace TAKEHOME_WEEK6
{
    public partial class Form1 : Form
    {
        public class product
        { 
         public string idbarang { get; set; }
         public string namabarang { get; set; }
         public string hargabarang { get; set; }
         public string stockbarang { get; set; }
         public string idkategori { get; set; }

            public product(string id , string nama , string harga , string stock , string kategori)
            { 
            this.idbarang = id;
            this.namabarang = nama;
            this.hargabarang = harga;
            this.stockbarang = stock;
            this.idkategori = kategori;
            }

        }
        public class kategori
        {
            public string idkategori {get; set;}
            public string namakategori { get; set; }

            public kategori(string id, string kat)
            { 
                this.idkategori= id;
                this.namakategori= kat;
            }
        }
        List<product> products = new List<product>();
        List <kategori> kategoris = new List<kategori>();
        List<string> id = new List<string>();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
       




        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID PRODUCT");
            dt.Columns.Add("NAMA PRODUK");
            dt.Columns.Add("HARGA");
            dt.Columns.Add("STOCK");
            dt.Columns.Add("ID CATEGORY");

            dt2.Columns.Add("ID CATEGORY");
            dt2.Columns.Add("NAMA CATEGORY");

            dgv_product.DataSource = dt;
            dgv_category.DataSource = dt2;

            products.Add(new product("J001" ,"JAS HITAM" , "100000" , "10" , "C1" ));
            products.Add(new product("T001", "T-shirt black men", "70000", "20", "C2"));
            products.Add(new product("T002", "T-shirt obsessive", "75000", "16", "C2"));
            products.Add(new product("R001", "Rok mini", "82000", "26", "C3"));
            products.Add(new product("J002", "Jeans biru", "90000", "5", "C4"));
            products.Add(new product("C001", "Celana pendek coklat", "60000", "11", "C4"));
            products.Add(new product("C002", "Cawat blink-blink", "1000000", "1", "C5"));
            products.Add(new product("R002", "Roca shirt", "50000", "8", "C2"));

            id.Add("J001");
            id.Add("T001");
            id.Add("T002");
            id.Add("R001");
            id.Add("J002");
            id.Add("C001");
            id.Add("C002");
            id.Add("R002");

            kategoris.Add(new kategori("C1" , "Jas"));
            kategoris.Add(new kategori("C2", "T-shirt"));
            kategoris.Add(new kategori("C3", "Rok"));
            kategoris.Add(new kategori("C4", "Celana"));
            kategoris.Add(new kategori("C5", "Cawat"));

            /*string id = products[0].idbarang;
            string nama = products[1].namabarang;
            string harga = products[2].hargabarang;
            string stock = products[3].stockbarang;
            string kategori = products[4].idkategori;

            string ide = kategoris[0].idkategori;
            string namakategori = kategoris[1].namakategori;
            */
            int hitung = 0;
            int hitung2 = 0;
            foreach (product i in products)
            {
                dt.Rows.Add(products[hitung].idbarang, products[hitung].namabarang, products[hitung].hargabarang, products[hitung].stockbarang, products[hitung].idkategori);
                hitung++;
            }
            
            foreach (kategori p in kategoris)
            {
                dt2.Rows.Add(kategoris[hitung2].idkategori, kategoris[hitung2].namakategori);
                hitung2++;
            }
        }

        private void bt_addcategory_Click(object sender, EventArgs e)
        {
            int kategorisudahada = 0;
            int index = 0;
            foreach (kategori x in kategoris)
            {
                if (kategoris[index].namakategori == tb_namacategory.Text)
                {
                    kategorisudahada++;
                }
                index++;
            }
            if (kategorisudahada == 1)
            {
                MessageBox.Show("hahahah...");
            }
            else
            {
                index++;
                int hitung2 = 0;
                kategoris.Add(new kategori("C" + index , tb_namacategory.Text));

                dt2.Rows.Clear();
                cb_category.Items.Clear();
                cb_filter.Items.Clear();
                foreach (kategori p in kategoris.ToList())
                {
                    dt2.Rows.Add(kategoris[hitung2].idkategori, kategoris[hitung2].namakategori);
                    cb_filter.Items.Add(kategoris[hitung2].namakategori);
                    cb_category.Items.Add(kategoris[hitung2].namakategori);
                    hitung2++;
                }

            }
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_removecategory_Click(object sender, EventArgs e)
        {
            int plus = dgv_category.CurrentCell.RowIndex;

            string kode = dgv_category.Rows[plus].Cells[0].Value.ToString();
            string ambilangkakode = kode.Substring(1, 1);
            dt2.Rows[plus].Delete();
            kategoris.RemoveAt(plus);
            cb_category.Items.Clear();
            cb_filter.Items.Clear();
            int hitung2 = 0;
            foreach (kategori p in kategoris.ToList())
            {
                dt2.Rows.Add(kategoris[hitung2].idkategori, kategoris[hitung2].namakategori);
                cb_filter.Items.Add(kategoris[hitung2].namakategori);
                cb_category.Items.Add(kategoris[hitung2].namakategori);
                hitung2++;
            }

            cb_filter.Text = string.Empty;
            dt2.Rows.Clear();
            foreach (string n in id.ToList())
            {
                id.Remove(n);
            }
            int hitung3 = 0;
            foreach (product h in products.ToList())
            {

                string idproduk = products[hitung3].idbarang;

                if (ambilangkakode != products[hitung3].idkategori)//diinput ulang bagi category yang tidak ke klik
                {
                    dt.Rows.Add(products[hitung3].idbarang, products[hitung3].namabarang, products[hitung3].hargabarang, products[hitung3].stockbarang, products[hitung3].idkategori);
                }
                if (ambilangkakode == products[hitung3].idkategori)
                {
                    products.Remove(h);
                }
                hitung3++;
            }
        }
    }
}
