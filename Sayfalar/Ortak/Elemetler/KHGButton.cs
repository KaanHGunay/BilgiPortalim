using System.Windows.Controls;

namespace Sayfalar.Ortak.Elemetler
{
    public class KHGButton : Button
    {
        public KHGButton()
        {
            Background = System.Windows.Media.Brushes.Transparent;
            Foreground = Ortak.YaziRengi;
            FontSize = Ortak.YaziBoyutu;
        }
    }
}
