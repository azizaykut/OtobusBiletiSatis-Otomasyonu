using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace otobüsbilet
{
    public partial class SatınAl : Form
    {
        SqlConnection conn;  // conn = baglanti 
        SqlCommand com; // com = komut ;
        SqlDataAdapter da;
        public SatınAl()
        {
            InitializeComponent();
        }

        void biletBul()
        {
            conn = new SqlConnection("Data Source=DESKTOP-CGMM00V;Initial Catalog=Kayıt;Integrated Security=True");
            conn.Open();
            da=new SqlDataAdapter("SELECT *FROM Satın_Al", conn);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            conn.Close();
        }

        private void SatınAl_Load(object sender, EventArgs e)
        {
            biletBul();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cmbOtobus.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmbNereden.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbNereye.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
  
            nudFiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            nmKoltuk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtisim.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtSoyisim.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            msktelefon.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Satın_Al(Otobüs,Nereden,Nereye,Fiyat,Koltukno,Ad,Soyad,Telefon) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
            com=new SqlCommand(sorgu, conn);
            com.Parameters.AddWithValue("@p1", cmbOtobus.Text);
            com.Parameters.AddWithValue("@p2", cmbNereden.Text);
            com.Parameters.AddWithValue("@p3", cmbNereye.Text);
            
            com.Parameters.AddWithValue("@p4", nudFiyat.Text);
            com.Parameters.AddWithValue("@p5", nmKoltuk.Text);
            com.Parameters.AddWithValue("@p6", txtisim.Text);
            com.Parameters.AddWithValue("@p7", txtSoyisim.Text);
            com.Parameters.AddWithValue("@p8", msktelefon.Text);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            biletBul();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Satın_Al WHERE Koltukno=@Koltukno";
            com = new SqlCommand(sorgu, conn);
            com.Parameters.AddWithValue("@Koltukno", Convert.ToInt32(nmKoltuk.Text));
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            biletBul();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Satın_Al SET Otobüs=@Otobüs,Nereden=@Nereden,Nereye=@Nereye,Fiyat=@Fiyat,Ad=@Ad,Soyad=@Soyad,Telefon=@Telefon WHERE Koltukno=@Koltukno";
            com=new SqlCommand(sorgu, conn);
            com.Parameters.AddWithValue("@Koltukno", Convert.ToInt32(nmKoltuk.Text));
            com.Parameters.AddWithValue("@Otobüs", cmbOtobus.Text);
            com.Parameters.AddWithValue("@Nereden", cmbNereden.Text);
            com.Parameters.AddWithValue("@Nereye", cmbNereye.Text);
            com.Parameters.AddWithValue("@Fiyat", nudFiyat.Text);
            com.Parameters.AddWithValue("@Ad", txtisim.Text);
            com.Parameters.AddWithValue("@Soyad", txtSoyisim.Text);
            com.Parameters.AddWithValue("@Telefon", msktelefon.Text);



            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            biletBul();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
