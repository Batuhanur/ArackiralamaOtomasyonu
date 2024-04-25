using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AraçKiralama
{
    class Araç_Kiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-41UJS1GM;Initial Catalog=Araç_Kiralama;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut,string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        public DataTable listele(SqlDataAdapter adtr,string sorgu )
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;

        }
        public void Boş_Araçlar(System.Windows.Forms.ComboBox combo, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu,baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();
        }

        public void CombodanGetir(System.Windows.Forms.ComboBox comboAraçlar, System.Windows.Forms.TextBox txtMarka, System.Windows.Forms.TextBox txtSeri, System.Windows.Forms.TextBox txtModel, System.Windows.Forms.TextBox txtRenk, string sorgu2)
        {
            baglanti.Open();
           
            SqlCommand komut = new SqlCommand( sorgu2 ,baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                txtMarka.Text = read["marka"].ToString();
                txtSeri.Text = read["seri"].ToString();
                txtModel.Text = read["model"].ToString();
                txtRenk.Text = read["renk"].ToString();
            }
            baglanti.Close();
        }

        public void TC_Ara(System.Windows.Forms.TextBox tcara, System.Windows.Forms.TextBox tc, System.Windows.Forms.TextBox adsoyad, System.Windows.Forms.TextBox telefon,string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();

            }
            baglanti.Close();
        }
        public void Ucret_Hesapla(System.Windows.Forms.ComboBox combokiraşekli, System.Windows.Forms.TextBox ucret, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (combokiraşekli.SelectedIndex == 0) ucret.Text = (int.Parse(read["Kiraucreti"].ToString()) *1).ToString();
                if (combokiraşekli.SelectedIndex == 1) ucret.Text = (int.Parse(read["Kiraucreti"].ToString()) * 0.80).ToString();
                if (combokiraşekli.SelectedIndex == 2) ucret.Text = (int.Parse(read["Kiraucreti"].ToString()) * 0.70).ToString();



            }
            baglanti.Close();
        }
        public void CombodanGetir(combobox araclar,System.Windows.Forms.TextBox marka, System.Windows.Forms.TextBox seri, System.Windows.Forms.TextBox model, System.Windows.Forms.TextBox renk,string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                model.Text = read["model"].ToString();
                renk.Text = read["renk"].ToString();


            }
            baglanti.Close();
        }

        public void satışhesapla(Label lbl)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(tutar) from satış ",baglanti);
            lbl.Text = "Toplam Tutar=" + komut.ExecuteScalar() + "TL";
            baglanti.Close();
        }


    }
}
