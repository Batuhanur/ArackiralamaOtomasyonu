
namespace AraçKiralama
{
    partial class frmSözleşme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSözleşme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtE_Yer = new System.Windows.Forms.TextBox();
            this.txtE_Tarih = new System.Windows.Forms.TextBox();
            this.txtE_No = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdsoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblE_yer = new System.Windows.Forms.Label();
            this.lblE_Tarih = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dateDönüş = new System.Windows.Forms.DateTimePicker();
            this.dateÇıkış = new System.Windows.Forms.DateTimePicker();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtGün = new System.Windows.Forms.TextBox();
            this.txtKiraucreti = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.comboKiraŞekli = new System.Windows.Forms.ComboBox();
            this.comboAraçlar = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAraçTeslim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTcAra);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtE_Yer);
            this.groupBox1.Controls.Add(this.txtE_Tarih);
            this.groupBox1.Controls.Add(this.txtE_No);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdsoyad);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Controls.Add(this.lblE_yer);
            this.groupBox1.Controls.Add(this.lblE_Tarih);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(226, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(115, 16);
            this.txtTcAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTcAra.MaxLength = 11;
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(96, 20);
            this.txtTcAra.TabIndex = 13;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(45, 14);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 18);
            this.label18.TabIndex = 12;
            this.label18.Text = "TC Ara";
            // 
            // txtE_Yer
            // 
            this.txtE_Yer.Location = new System.Drawing.Point(115, 204);
            this.txtE_Yer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtE_Yer.Name = "txtE_Yer";
            this.txtE_Yer.Size = new System.Drawing.Size(96, 20);
            this.txtE_Yer.TabIndex = 11;
            this.txtE_Yer.TextChanged += new System.EventHandler(this.txtE_Yer_TextChanged);
            // 
            // txtE_Tarih
            // 
            this.txtE_Tarih.Location = new System.Drawing.Point(115, 173);
            this.txtE_Tarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtE_Tarih.Name = "txtE_Tarih";
            this.txtE_Tarih.Size = new System.Drawing.Size(96, 20);
            this.txtE_Tarih.TabIndex = 10;
            this.txtE_Tarih.TextChanged += new System.EventHandler(this.txtE_Tarih_TextChanged);
            // 
            // txtE_No
            // 
            this.txtE_No.Location = new System.Drawing.Point(115, 142);
            this.txtE_No.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtE_No.Name = "txtE_No";
            this.txtE_No.Size = new System.Drawing.Size(96, 20);
            this.txtE_No.TabIndex = 9;
            this.txtE_No.TextChanged += new System.EventHandler(this.txtE_No_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(115, 110);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(96, 20);
            this.txtTelefon.TabIndex = 8;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // txtAdsoyad
            // 
            this.txtAdsoyad.Location = new System.Drawing.Point(115, 79);
            this.txtAdsoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdsoyad.Name = "txtAdsoyad";
            this.txtAdsoyad.Size = new System.Drawing.Size(96, 20);
            this.txtAdsoyad.TabIndex = 7;
            this.txtAdsoyad.TextChanged += new System.EventHandler(this.txtAdsoyad_TextChanged);
            this.txtAdsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdsoyad_KeyPress);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(115, 48);
            this.txtTC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(96, 20);
            this.txtTC.TabIndex = 6;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // lblE_yer
            // 
            this.lblE_yer.AutoSize = true;
            this.lblE_yer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblE_yer.Location = new System.Drawing.Point(7, 202);
            this.lblE_yer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblE_yer.Name = "lblE_yer";
            this.lblE_yer.Size = new System.Drawing.Size(102, 15);
            this.lblE_yer.TabIndex = 5;
            this.lblE_yer.Text = "E_Verildiği Yer";
            // 
            // lblE_Tarih
            // 
            this.lblE_Tarih.AutoSize = true;
            this.lblE_Tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblE_Tarih.Location = new System.Drawing.Point(17, 172);
            this.lblE_Tarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblE_Tarih.Name = "lblE_Tarih";
            this.lblE_Tarih.Size = new System.Drawing.Size(91, 15);
            this.lblE_Tarih.TabIndex = 4;
            this.lblE_Tarih.Text = "Ehliyet Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ehliyet No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adsoyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.btnGüncelle);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.dateDönüş);
            this.groupBox2.Controls.Add(this.dateÇıkış);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.txtGün);
            this.groupBox2.Controls.Add(this.txtKiraucreti);
            this.groupBox2.Controls.Add(this.txtRenk);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.txtSeri);
            this.groupBox2.Controls.Add(this.txtMarka);
            this.groupBox2.Controls.Add(this.comboKiraŞekli);
            this.groupBox2.Controls.Add(this.comboAraçlar);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(251, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(637, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(365, 207);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(135, 25);
            this.btnTemizle.TabIndex = 27;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapla.ImageIndex = 2;
            this.btnHesapla.ImageList = this.ımageList1;
            this.btnHesapla.Location = new System.Drawing.Point(541, 194);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(92, 38);
            this.btnHesapla.TabIndex = 26;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "güncelle icon.png");
            this.ımageList1.Images.SetKeyName(1, "ekle.jpeg");
            this.ımageList1.Images.SetKeyName(2, "hesap makinesi.jpeg");
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.ImageIndex = 0;
            this.btnGüncelle.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(129, 193);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(93, 39);
            this.btnGüncelle.TabIndex = 25;
            this.btnGüncelle.Text = " Güncelle";
            this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 1;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(16, 193);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 39);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = " Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dateDönüş
            // 
            this.dateDönüş.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDönüş.Location = new System.Drawing.Point(365, 181);
            this.dateDönüş.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateDönüş.Name = "dateDönüş";
            this.dateDönüş.Size = new System.Drawing.Size(136, 20);
            this.dateDönüş.TabIndex = 23;
            // 
            // dateÇıkış
            // 
            this.dateÇıkış.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateÇıkış.Location = new System.Drawing.Point(365, 151);
            this.dateÇıkış.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateÇıkış.Name = "dateÇıkış";
            this.dateÇıkış.Size = new System.Drawing.Size(136, 20);
            this.dateÇıkış.TabIndex = 22;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(365, 120);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(136, 20);
            this.txtTutar.TabIndex = 19;
            this.txtTutar.TextChanged += new System.EventHandler(this.txtTutar_TextChanged);
            // 
            // txtGün
            // 
            this.txtGün.Location = new System.Drawing.Point(365, 90);
            this.txtGün.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGün.Name = "txtGün";
            this.txtGün.Size = new System.Drawing.Size(136, 20);
            this.txtGün.TabIndex = 18;
            // 
            // txtKiraucreti
            // 
            this.txtKiraucreti.Location = new System.Drawing.Point(365, 62);
            this.txtKiraucreti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKiraucreti.Name = "txtKiraucreti";
            this.txtKiraucreti.Size = new System.Drawing.Size(136, 20);
            this.txtKiraucreti.TabIndex = 17;
            this.txtKiraucreti.TextChanged += new System.EventHandler(this.txtKiraÜcreti_TextChanged);
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(107, 151);
            this.txtRenk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(136, 20);
            this.txtRenk.TabIndex = 16;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(107, 123);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(135, 20);
            this.txtModel.TabIndex = 15;
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(107, 94);
            this.txtSeri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(135, 20);
            this.txtSeri.TabIndex = 14;
            this.txtSeri.TextChanged += new System.EventHandler(this.txtSeri_TextChanged);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(107, 64);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(135, 20);
            this.txtMarka.TabIndex = 13;
            this.txtMarka.TextChanged += new System.EventHandler(this.txtMarka_TextChanged);
            // 
            // comboKiraŞekli
            // 
            this.comboKiraŞekli.FormattingEnabled = true;
            this.comboKiraŞekli.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık",
            "Aylık"});
            this.comboKiraŞekli.Location = new System.Drawing.Point(365, 33);
            this.comboKiraŞekli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboKiraŞekli.Name = "comboKiraŞekli";
            this.comboKiraŞekli.Size = new System.Drawing.Size(136, 21);
            this.comboKiraŞekli.TabIndex = 12;
            this.comboKiraŞekli.SelectedIndexChanged += new System.EventHandler(this.comboKiraŞekli_SelectedIndexChanged);
            // 
            // comboAraçlar
            // 
            this.comboAraçlar.FormattingEnabled = true;
            this.comboAraçlar.Location = new System.Drawing.Point(107, 34);
            this.comboAraçlar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboAraçlar.Name = "comboAraçlar";
            this.comboAraçlar.Size = new System.Drawing.Size(136, 21);
            this.comboAraçlar.TabIndex = 11;
            this.comboAraçlar.SelectedIndexChanged += new System.EventHandler(this.comboAraçlar_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(278, 181);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 15);
            this.label17.TabIndex = 10;
            this.label17.Text = "Dönüş Tarihi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(289, 151);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 15);
            this.label16.TabIndex = 9;
            this.label16.Text = "Çıkış Tarihi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(317, 120);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 15);
            this.label15.TabIndex = 8;
            this.label15.Text = "Tutar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(323, 90);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "Gün";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(289, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "Kira Ücreti";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(295, 33);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Kira Şekli";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(69, 151);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Renk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(65, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Model";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(76, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Seri";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(65, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(59, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Araçlar";
            // 
            // btnAraçTeslim
            // 
            this.btnAraçTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAraçTeslim.Location = new System.Drawing.Point(795, 437);
            this.btnAraçTeslim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAraçTeslim.Name = "btnAraçTeslim";
            this.btnAraçTeslim.Size = new System.Drawing.Size(93, 41);
            this.btnAraçTeslim.TabIndex = 3;
            this.btnAraçTeslim.Text = "Araç Teslim";
            this.btnAraçTeslim.UseVisualStyleBackColor = true;
            this.btnAraçTeslim.Click += new System.EventHandler(this.btnAraçTeslim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 255);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(880, 177);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(436, 449);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Alacak/verecek Durumu";
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(601, 449);
            this.txtEkstra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(96, 20);
            this.txtEkstra.TabIndex = 12;
            // 
            // frmSözleşme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(927, 556);
            this.Controls.Add(this.txtEkstra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAraçTeslim);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSözleşme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Sözleşme Sayfası";
            this.Load += new System.EventHandler(this.frmSözleşme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtE_Yer;
        private System.Windows.Forms.TextBox txtE_Tarih;
        private System.Windows.Forms.TextBox txtE_No;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdsoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblE_yer;
        private System.Windows.Forms.Label lblE_Tarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDönüş;
        private System.Windows.Forms.DateTimePicker dateÇıkış;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtGün;
        private System.Windows.Forms.TextBox txtKiraucreti;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.ComboBox comboKiraŞekli;
        private System.Windows.Forms.ComboBox comboAraçlar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAraçTeslim;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.ImageList ımageList1;
    }
}