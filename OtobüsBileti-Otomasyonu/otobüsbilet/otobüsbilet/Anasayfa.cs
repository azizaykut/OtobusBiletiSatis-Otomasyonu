using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobüsbilet
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
            PanelDesign();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void PanelDesign()
        {
            panel_otobüs.Visible = false;
            hakkımızda_panel.Visible = false;
        }
        private void HideMenu()
        {
            if(panel_otobüs.Visible==true)
                panel_otobüs.Visible=false;
            if(hakkımızda_panel.Visible==true)
                hakkımızda_panel.Visible=false;
        }
        private void ShowMenu(Panel menu)
        {
            if(menu.Visible==false)
            {
                HideMenu();
                menu.Visible=true;
            }
            else
            {
                menu.Visible=false;
            }
        }

        private void otobus_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_otobüs);
        }

        private void travego_Click(object sender, EventArgs e)
        {
            HideMenu();
            SatınAl satın = new SatınAl();
            satın.Show();
            this.Hide();
        }

        private void neoplan_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void setra_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void bize_ulas_Click(object sender, EventArgs e)
        {
            ShowMenu(hakkımızda_panel);
        }

        private void adres_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void telefon_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void hakkımızda_Click(object sender, EventArgs e)
        {
            HideMenu();
            Hakkımızda hakkımız = new Hakkımızda();
            hakkımız.Show();
            this.Hide();
        }

        private void cıkısyap_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
