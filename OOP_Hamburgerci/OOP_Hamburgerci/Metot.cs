using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public class Metot
    {
        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = true;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 1;
                }
                else if (item is GroupBox)
                {
                    Temizle(((GroupBox)item).Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    Temizle(((FlowLayoutPanel)item).Controls);
                }
            }
        }
    }
}
