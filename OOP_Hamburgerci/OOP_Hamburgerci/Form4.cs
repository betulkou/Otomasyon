using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal eksMalzGeliri = 0;
            int satisAdedi = 0;

            foreach (Siparis siparis in Form1.siparisler)
            {
                ciro += siparis.ToplamTutar;
                satisAdedi += siparis.Adet;
                foreach (Ekstra ekstra in siparis.EkstraMalzemesi)
                {
                    eksMalzGeliri += ekstra.Fiyati;
                }

                lbxTumSiparisler.Items.Add(siparis);
            }

            lblCiro.Text = ciro.ToString("C2");
            lblToplamSiparisSayisi.Text = lbxTumSiparisler.Items.Count.ToString();
            lblEkstraMalzemeGeliri.Text = eksMalzGeliri.ToString("C2");
            lblSatilanUrunAdedi.Text = satisAdedi.ToString();
        }
    }
}
