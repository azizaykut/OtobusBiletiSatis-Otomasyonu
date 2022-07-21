using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace otobüsbilet
{
    public partial class Giris : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=DESKTOP-CGMM00V;Initial Catalog=Kayıt;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From Kullanıcı_Bilgi where kullanıcı_adi='" + textBox1.Text +
                "'And sifre='" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                Anasayfa gecis = new Anasayfa();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            con.Close();
    }
    }
}
