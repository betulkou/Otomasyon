using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{
    public class Siparis
    {
        public Menu SeciliMenu { get; set; }
        public List<Ekstra> EkstraMalzemesi { get; set; }
        public Boyut Boyutu { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }


        public void Hesapla()
        {
            // Menü Fiyatı= 20 TL
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;

            switch (Boyutu)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10M; // ToplamTutar = ToplamTutar + (ToplamTutar * 0.10) => ToplamTutar = 20 + (20 * 0.1)
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;
            }

            foreach (Ekstra ekstra in EkstraMalzemesi)
                ToplamTutar += ekstra.Fiyati;

            ToplamTutar = ToplamTutar * Adet;
        }

        public override string ToString()
        {
            if (EkstraMalzemesi.Count < 1)
            {
                return string.Format("{0} Menü x {1} Adet, {2} Boy, Toplam: {3}", SeciliMenu.MenuAdi, Adet, Boyutu.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                string eksMalzemeler = null;
                foreach (Ekstra ekstra in EkstraMalzemesi)
                {
                    eksMalzemeler += ekstra.EkstraAdi + ", ";
                }
                // eksMalzemeler = ketçap, mayonez, ranch sos, 

                eksMalzemeler = eksMalzemeler.Trim(',', ' '); // eksMalzemeler = ketçap, mayonez, ranch sos

                return string.Format("{0} Menü x {1} Adet, {2} Boy, ({3}) Toplam: {4}", SeciliMenu.MenuAdi, Adet, Boyutu.ToString(), eksMalzemeler, ToplamTutar.ToString("C2"));
            }
        }
    }
}
