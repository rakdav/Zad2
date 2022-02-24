using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Zad2
{
    internal class Employs:Employ
    {
        private int scale;
        public int Schale 
        {
            get { return scale; }
            set
            {
                if (value <= 100) scale = 100;
                else
                {
                    scale = 0;
                    MessageBox.Show("Введите число меньше" +
                        " или равное 100");
                }
            }
        }

        public Employs(string fio,string dolg,
            double oklad, int schale):base(fio,dolg,oklad)
        {
            Schale = schale;
        }

        public new void  AddOklad()
        {
            if(scale>=60&&scale<=75) Oklad = 1.20 * Oklad;
            else if(scale>=75&&scale<90) Oklad = 1.40 * Oklad;
            else if (scale>=90&&scale<=100) Oklad = 1.60 * Oklad;
        }
        public new string Print()
        {
            return $"Фамилия:{FirstName}, должность:{Vacetion}," +
                   $" оклад:{Oklad:F2}, рейтинг:{scale}";
        }
    }
}
