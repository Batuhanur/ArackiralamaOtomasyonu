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
    public partial class frmAraçKayıt : Form
    {
        Araç_Kiralama arackiralama = new Araç_Kiralama();
        public frmAraçKayıt()
        {
            InitializeComponent();
        }

        private void btnresim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Sericombo.Items.Clear();
                if (Markacombo.SelectedItem .ToString () =="Opel")
                {
                    Sericombo.Items.Add("Astra");
                    Sericombo.Items.Add("Vectra");
                    Sericombo.Items.Add("Corsa");

                }
                else if(Markacombo.SelectedIndex==1)
                {
                    Sericombo.Items.Add("Megane");
                    Sericombo.Items.Add("Clio");
                }
                else if (Markacombo.SelectedIndex == 2)
                {
                    Sericombo.Items.Add("Linea");
                    Sericombo.Items.Add("Egea");
                }
                else if (Markacombo.SelectedIndex == 3)
                {
                    Sericombo.Items.Add("Fiesta");
                    Sericombo.Items.Add("Focus");
                }
            }
            catch
            {
                ;
            }
           
           
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            string cümle = "insert into araç(plaka,marka,seri,model,renk,km,yakıt,kiraucreti,resim,tarih,durumu) values(@plaka,@marka,@seri,@model,@renk,@km,@yakıt,@kiraucreti,@resim,@tarih,@durumu)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka",Plakatxt.Text );
            komut2.Parameters.AddWithValue("@marka", Markacombo.Text);
            komut2.Parameters.AddWithValue("@seri", Sericombo.Text);
            komut2.Parameters.AddWithValue("@model", Modeltxt.Text);
            komut2.Parameters.AddWithValue("@renk", Renktxt.Text);
            komut2.Parameters.AddWithValue("@km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakıt", Yakıtcombo.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse (Ücrettxt.Text));
            komut2.Parameters.AddWithValue("@resim",pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@durumu", "BOŞ");
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            Sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox ) item.Text = "";
            pictureBox1.ImageLocation = "";
            MessageBox.Show("Araç Başarıyla Kaydedildi");



        }

        private void frmAraçKayıt_Load(object sender, EventArgs e)
        {

        }

        private void Sericombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
