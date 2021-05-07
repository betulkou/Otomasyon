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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            Form1.menuler.Add(new Menu { MenuAdi = txtMenuAdi.Text, Fiyati = nmrMenuFiyati.Value });

            Metot.Temizle(this.Controls);

            MessageBox.Show("Menü Başarıyla Eklendi");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void grpMenuEkle_Enter(object sender, EventArgs e)
        {

        }
    }
}
