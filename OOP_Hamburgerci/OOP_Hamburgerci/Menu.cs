using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{
    // Bir menünün ..... özelliği vardır?
    public class Menu
    {
        public string MenuAdi { get; set; }
        public decimal Fiyati { get; set; }

        // Nesne adıyla çağırıldığında, comboBox'ta ... Menü şeklinde görünmesi için:
        public override string ToString()
        {
            return MenuAdi + " Menü";
        }
    }
}
