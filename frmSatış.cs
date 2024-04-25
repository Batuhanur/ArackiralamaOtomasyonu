using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralama
{
    public partial class frmSatış : Form
    {

        public frmSatış()
        {
            InitializeComponent();
        }
        Araç_Kiralama araç = new Araç_Kiralama();

        private void frmSatış_Load(object sender, EventArgs e)
        {
            string sorgu = "select *from satış";
            SqlDataAdapter adtr = new SqlDataAdapter();
            dataGridView1.DataSource = araç.listele(adtr,sorgu);
            araç.satışhesapla(label1);

        }
    }
}
