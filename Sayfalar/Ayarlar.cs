using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sayfalar
{
    public static class Ayarlar
    {
        public static void Olustur(Grid g)
        {
            g.Children.Clear();
            g.ColumnDefinitions.Clear();
            g.RowDefinitions.Clear();

            Islemler.RowOlustur(g, 1, 2, 2, 2, 1);
            Islemler.ColumnOlustur(g, 1, 2, 1);
        }
    }
}
