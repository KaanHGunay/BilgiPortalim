using System.Windows.Controls;

namespace Sayfalar.Ortak.Elemetler
{
    public class KHGListView : ListView
    {
        public KHGListView()
        {
            Background = System.Windows.Media.Brushes.Transparent;
            Foreground = Secenekler.YaziRengi;
        }
    }
}
