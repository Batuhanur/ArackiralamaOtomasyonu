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
    public partial class frmSözleşme : Form
    {
        public frmSözleşme()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        Araç_Kiralama arac = new Araç_Kiralama();
        private void frmSözleşme_Load(object sender, EventArgs e)
        {
            Boş_Araçlar();
            Yenile();

        }

        private void Boş_Araçlar()
        {
            string sorgu2 = "select*from araç where durumu='BOŞ'";
            arac.Boş_Araçlar(comboAraçlar, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select*from sözleşme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from araç where plaka like'" +comboAraçlar.SelectedItem+ "'";
            arac.CombodanGetir(comboAraçlar, txtMarka, txtSeri, txtModel, txtRenk, sorgu2); 
        }

        private void comboKiraŞekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from araç where plaka like'" + comboAraçlar.SelectedItem + "'";
            arac.Ucret_Hesapla(comboKiraŞekli, txtKiraucreti, sorgu2);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan  gun = DateTime.Parse(dateDönüş.Text) - DateTime.Parse(dateÇıkış.Text);
            int gun2 = gun.Days;
            txtGün.Text = gun2.ToString();
            txtTutar.Text = (gun2 * int.Parse(txtKiraucreti.Text)).ToString();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
         
          string sorgu2 = "insert into sözleşme(tc,adsoyad,telefon,ehliyetno,e_tarih,e_yer,plaka,marka,seri,model,renk,kiraşekli,kiraucreti,gun,tutar,ctarih,dtarih) values (@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@model,@renk,@kiraşekli,@kiraucreti,@gun,@tutar,@ctarih,@dtarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtE_No.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtE_Tarih.Text);
            komut2.Parameters.AddWithValue("@e_yer", txtE_Yer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboAraçlar.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@model", txtModel.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kiraşekli", comboKiraŞekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse (txtKiraucreti.Text));
            komut2.Parameters.AddWithValue("@gun", int.Parse (txtGün.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", dateÇıkış.Text);
            komut2.Parameters.AddWithValue("@dtarih", dateDönüş.Text);
            arac.ekle_sil_güncelle(komut2, sorgu2);

            string sorgu3 = "update araç set durumu='DOLU'where plaka='"+comboAraçlar.Text+"'";
            SqlCommand komut3 = new SqlCommand();
            arac.ekle_sil_güncelle(komut3, sorgu3);
            comboAraçlar.Items.Clear();
            Boş_Araçlar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboAraçlar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme Eklendi");
        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeri_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update sözleşme set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,ehliyetno=@ehliyetno,e_tarih=@e_tarih,e_yer=@e_yer,marka=@marka,seri=@seri,model=@model,renk=@renk,kiraşekli=@kiraşekli,kiraucreti=@kiraucreti,gun=@gun,tutar=@tutar,ctarih=@ctarih,dtarih=@dtarih where plaka =@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtE_No.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtE_Tarih.Text);
            komut2.Parameters.AddWithValue("@e_yer", txtE_Yer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboAraçlar.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@model", txtModel.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kiraşekli", comboKiraŞekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraucreti.Text));
            komut2.Parameters.AddWithValue("@gun", int.Parse(txtGün.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", dateÇıkış.Text);
            komut2.Parameters.AddWithValue("@dtarih", dateDönüş.Text);
            arac.ekle_sil_güncelle(komut2, sorgu2);
            comboAraçlar.Items.Clear();
            Boş_Araçlar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboAraçlar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme Güncellendi");
        }

        private void txtKiraÜcreti_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            dateÇıkış.Text = DateTime.Now.ToShortDateString();
            dateDönüş.Text = DateTime.Now.ToShortDateString();
            comboKiraŞekli.Text = "";
            txtKiraucreti.Text = "";
            txtGün.Text = "";
            txtTutar.Text = "";
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            
            if (txtTcAra.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select *from müşteri where tc like'" + txtTcAra.Text + "'";
            arac.TC_Ara(txtTcAra,txtTC, txtAdsoyad, txtTelefon, sorgu2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTC.Text = satır.Cells[0].Value.ToString();
            txtAdsoyad.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtE_No.Text = satır.Cells[3].Value.ToString();
            txtE_Tarih.Text = satır.Cells[4].Value.ToString();
            txtE_Yer.Text = satır.Cells[5].Value.ToString();
            comboAraçlar.Text = satır.Cells[6].Value.ToString();
            txtMarka.Text = satır.Cells[7].Value.ToString();
            txtSeri.Text = satır.Cells[8].Value.ToString();
            txtModel.Text = satır.Cells[9].Value.ToString();
            txtRenk.Text = satır.Cells[10].Value.ToString();
            comboKiraŞekli.Text = satır.Cells[11].Value.ToString();
            txtKiraucreti.Text = satır.Cells[12].Value.ToString();
            txtGün.Text = satır.Cells[13].Value.ToString();
            txtTutar.Text = satır.Cells[14].Value.ToString();
            dateÇıkış.Text = satır.Cells[15].Value.ToString();
            dateDönüş.Text = satır.Cells[16].Value.ToString();
 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            //Gün farkı hesapla
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime dönüş = DateTime.Parse(satır.Cells["dtarih"].Value.ToString());
            int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunfarkı = bugün - dönüş;
            int _gunfarkı = gunfarkı.Days;
            int ucretfarkı;
            //ücret farkı hesapla
            ucretfarkı = _gunfarkı * ucret;
            txtEkstra.Text = ucretfarkı.ToString();
            //Toplam tutar hesaplama
        }

        private void btnAraçTeslim_Click(object sender, EventArgs e)
        {
            if (txtEkstra.Text!="")
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
                int tutar = int.Parse(satır.Cells["tutar"].Value.ToString());
                DateTime çıkış = DateTime.Parse(satır.Cells["ctarih"].Value.ToString());
                TimeSpan gun = bugün - çıkış;
                int _gun = gun.Days;
                int toplamtutar = _gun * ucret;
                ///Toplamtutar,_gun ve ucret satış tablosuna aktarılacak
                string sorgu1 = "delete from sözleşme where plaka='"+satır.Cells["plaka"].Value.ToString ()+"' ";
                SqlCommand komut = new SqlCommand();
                arac.ekle_sil_güncelle(komut, sorgu1);
                string sorgu2 = "update araç set durumu='BOŞ'where plaka='" + satır.Cells["plaka"].Value.ToString() +"'";
                SqlCommand komut3 = new SqlCommand();
                arac.ekle_sil_güncelle(komut3, sorgu2);

                string sorgu3 = "insert into satış(tc,adsoyad,plaka,renk,marka,seri,model,gun,tutar,tarih1,tarih2,fiyat) values (@tc,@adsoyad,@plaka,@renk,@marka,@seri,@model,@gun,@tutar,@tarih1,@tarih2,@fiyat)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@tc",satır.Cells ["tc"].Value .ToString ());
                komut2.Parameters.AddWithValue("@adsoyad", satır.Cells["adsoyad"].Value.ToString());
                komut2.Parameters.AddWithValue("@plaka", satır.Cells["plaka"].Value.ToString());
                komut2.Parameters.AddWithValue("@renk", satır.Cells["renk"].Value.ToString());
                komut2.Parameters.AddWithValue("@marka", satır.Cells["marka"].Value.ToString());
                komut2.Parameters.AddWithValue("@seri", satır.Cells["seri"].Value.ToString());
                komut2.Parameters.AddWithValue("@model", satır.Cells["model"].Value.ToString());
                komut2.Parameters.AddWithValue("@gun", _gun);
                komut2.Parameters.AddWithValue("@tutar", toplamtutar);
                komut2.Parameters.AddWithValue("@tarih1", satır.Cells["ctarih"].Value.ToString());
                komut2.Parameters.AddWithValue("@tarih2", DateTime.Now.ToShortDateString());
                komut2.Parameters.AddWithValue("@fiyat", ucret);

                arac.ekle_sil_güncelle(komut2, sorgu3);
                MessageBox.Show("Araç Teslim Edildi");
                comboAraçlar.Text = "";
                comboAraçlar.Items.Clear();
                Boş_Araçlar();
                Yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                comboAraçlar.Text = "";
                Temizle();
                txtEkstra.Text = "";

            }
            else if (txtEkstra.Text == "")
            {
                MessageBox.Show("Lütfen Seçim Yapınız", "Uyarı");
            }
        }

        private void txtE_Yer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtE_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtE_Tarih_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
