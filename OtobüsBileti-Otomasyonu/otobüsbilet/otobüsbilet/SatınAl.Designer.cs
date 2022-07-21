namespace otobüsbilet
{
    partial class SatınAl
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOtobus = new System.Windows.Forms.ComboBox();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmKoltuk = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmKoltuk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(836, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otobüs Seçiniz";
            // 
            // cmbOtobus
            // 
            this.cmbOtobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOtobus.FormattingEnabled = true;
            this.cmbOtobus.Items.AddRange(new object[] {
            "Travego",
            "Neoplan",
            "Setra"});
            this.cmbOtobus.Location = new System.Drawing.Point(936, 47);
            this.cmbOtobus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbOtobus.Name = "cmbOtobus";
            this.cmbOtobus.Size = new System.Drawing.Size(140, 21);
            this.cmbOtobus.TabIndex = 2;
            // 
            // cmbNereden
            // 
            this.cmbNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Items.AddRange(new object[] {
            "ADIYAMAN",
            "AFYONKARAHİSAR",
            "AĞRI",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKARİ",
            "HATAY",
            "ISPARTA",
            "MERSİN",
            "İSTANBUL",
            "İZMİR",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KOCAELİ",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "KAHRAMANMARAŞ",
            "MARDİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "RİZE",
            "SAKARYA",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "ŞANLIURFA",
            "UŞAK",
            "VAN",
            "YOZGAT",
            "ZONGULDAK",
            "AKSARAY",
            "BAYBURT",
            "KARAMAN",
            "KIRIKKALE",
            "BATMAN",
            "ŞIRNAK",
            "BARTIN",
            "ARDAHAN",
            "IĞDIR",
            "YALOVA",
            "KARABÜK",
            "KİLİS",
            "OSMANİYE",
            "DÜZCE"});
            this.cmbNereden.Location = new System.Drawing.Point(72, 37);
            this.cmbNereden.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(140, 21);
            this.cmbNereden.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nereden : ";
            // 
            // cmbNereye
            // 
            this.cmbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Items.AddRange(new object[] {
            "ADIYAMAN",
            "AFYONKARAHİSAR",
            "AĞRI",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKARİ",
            "HATAY",
            "ISPARTA",
            "MERSİN",
            "İSTANBUL",
            "İZMİR",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KOCAELİ",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "KAHRAMANMARAŞ",
            "MARDİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "RİZE",
            "SAKARYA",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "ŞANLIURFA",
            "UŞAK",
            "VAN",
            "YOZGAT",
            "ZONGULDAK",
            "AKSARAY",
            "BAYBURT",
            "KARAMAN",
            "KIRIKKALE",
            "BATMAN",
            "ŞIRNAK",
            "BARTIN",
            "ARDAHAN",
            "IĞDIR",
            "YALOVA",
            "KARABÜK",
            "KİLİS",
            "OSMANİYE",
            "DÜZCE"});
            this.cmbNereye.Location = new System.Drawing.Point(72, 77);
            this.cmbNereye.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(140, 21);
            this.cmbNereye.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nereye :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(881, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fiyat :";
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(936, 257);
            this.nudFiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudFiyat.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudFiyat.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(140, 20);
            this.nudFiyat.TabIndex = 10;
            this.nudFiyat.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Teal;
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(359, 329);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(105, 40);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNereye);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbNereden);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(864, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 123);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(716, 234);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Red;
            this.BtnSil.ForeColor = System.Drawing.Color.White;
            this.BtnSil.Location = new System.Drawing.Point(150, 329);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(88, 40);
            this.BtnSil.TabIndex = 14;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnGüncelle.ForeColor = System.Drawing.Color.White;
            this.BtnGüncelle.Location = new System.Drawing.Point(255, 329);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(90, 40);
            this.BtnGüncelle.TabIndex = 15;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = false;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(936, 407);
            this.msktelefon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(128, 20);
            this.msktelefon.TabIndex = 21;
            // 
            // mskTel
            // 
            this.mskTel.AutoSize = true;
            this.mskTel.Location = new System.Drawing.Point(870, 410);
            this.mskTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(58, 13);
            this.mskTel.TabIndex = 20;
            this.mskTel.Text = "Telefon :";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(936, 372);
            this.txtSoyisim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(128, 20);
            this.txtSoyisim.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(868, 372);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Soyisim :";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(936, 329);
            this.txtisim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(128, 20);
            this.txtisim.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(888, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "İsim :";
            // 
            // nmKoltuk
            // 
            this.nmKoltuk.Location = new System.Drawing.Point(936, 296);
            this.nmKoltuk.Name = "nmKoltuk";
            this.nmKoltuk.Size = new System.Drawing.Size(120, 20);
            this.nmKoltuk.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(854, 298);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Koltuk No : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(51, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 31);
            this.label9.TabIndex = 24;
            this.label9.Text = "<<<";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(881, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tarih :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(936, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // SatınAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1167, 543);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmKoltuk);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbOtobus);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SatınAl";
            this.Text = "SatınAl";
            this.Load += new System.EventHandler(this.SatınAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmKoltuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Label mskTel;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmKoltuk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}