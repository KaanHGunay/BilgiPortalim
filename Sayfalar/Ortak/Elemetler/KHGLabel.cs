using System.Windows.Controls;

namespace Sayfalar.Ortak.Elemetler
{
    public class KHGLabel : Label
    {
        public KHGLabel()
        {
            Foreground = Secenekler.YaziRengi;
            Background = System.Windows.Media.Brushes.Transparent;
            HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            VerticalAlignment = System.Windows.VerticalAlignment.Center;
            FontSize = Secenekler.YaziBoyutu;
        }
    }
}
