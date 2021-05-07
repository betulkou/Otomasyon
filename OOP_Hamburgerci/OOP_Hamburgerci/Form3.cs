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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkstraKaydet_Click(object sender, EventArgs e)
        {
            Form1.ekstralar.Add(new Ekstra { EkstraAdi = txtEkstraAdi.Text, Fiyati = nmrEkstraFiyati.Value });

            Metot.Temizle(this.Controls);

            MessageBox.Show("Ekstra Malzeme Başarıyla Eklendi");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void grpEsktraMalzemeEkle_Enter(object sender, EventArgs e)
        {

        }
    }
}
