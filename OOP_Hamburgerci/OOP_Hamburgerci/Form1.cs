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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Siparis> siparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu{ MenuAdi= "Big King", Fiyati= 18.25M },
            new Menu{ MenuAdi= "Double King Chicken", Fiyati= 16.50M },
            new Menu{ MenuAdi= "Big Royal", Fiyati= 21.75M },
            new Menu{ MenuAdi= "King Chicken", Fiyati= 14.00M },
            new Menu{ MenuAdi= "Whooper", Fiyati= 20.00M },
            new Menu{ MenuAdi= "Steak House", Fiyati= 19.50M }
        };

        public static List<Ekstra> ekstralar = new List<Ekstra>()
        {
            new Ekstra { EkstraAdi="Ketçap", Fiyati= 0.25M},
            new Ekstra { EkstraAdi="Mayonez", Fiyati= 0.25M},
            new Ekstra { EkstraAdi="Hardal", Fiyati= 0.75M },
            new Ekstra { EkstraAdi="BBQ", Fiyati= 0.75M },
            new Ekstra { EkstraAdi="Ranch", Fiyati= 1.00M },
            new Ekstra { EkstraAdi="Buffalo Sos", Fiyati= 1.25M },
            new Ekstra { EkstraAdi="Soğan Halkası", Fiyati= 4.90M}
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
                cmbMenu.Items.Add(item);

            foreach (Ekstra item in ekstralar)
                flpEsktraMalzeme.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item });

            foreach (Siparis item in mevcutSiparisler)
                lbxSiparisler.Items.Add(item);

            cmbMenu.SelectedIndex = 0;
            rdoKucuk.Checked = true;

            TutarHesapla();
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Menu)cmbMenu.SelectedItem;

            if (rdoKucuk.Checked) // rdoKucuk.Checked == true
                yeniSiparis.Boyutu = Boyut.Kucuk;
            else if (rdoOrta.Checked)
                yeniSiparis.Boyutu = Boyut.Orta;
            else
                yeniSiparis.Boyutu = Boyut.Buyuk;

            yeniSiparis.EkstraMalzemesi = new List<Ekstra>();
            foreach (CheckBox item in flpEsktraMalzeme.Controls)
            {
                if (item.Checked)
                    yeniSiparis.EkstraMalzemesi.Add((Ekstra)item.Tag);
            }

            yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla();

            lbxSiparisler.Items.Add(yeniSiparis);
            siparisler.Add(yeniSiparis);
            mevcutSiparisler.Add(yeniSiparis);

            TutarHesapla();

            Metot.Temizle(this.Controls);
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis gelen = (Siparis)lbxSiparisler.Items[i];
                toplamTutar += gelen.ToplamTutar;
            }

            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı: " + TutarHesapla().ToString("C2") + "\nSatın Alma İşlemini Tamamlamak İster Misiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz Tamamlandı!");
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi!");
            }
        }

        private void nmrAdet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxSiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flpEsktraMalzeme_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
