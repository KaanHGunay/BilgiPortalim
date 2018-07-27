using System.Windows.Media;

namespace Sayfalar
{
    public static class Secenekler
    {
        public static double YaziBoyutu
        {
            get { return 25; }
        }

        public static Brush YaziRengi
        {
            get { return new SolidColorBrush(Color.FromRgb(255, 255, 255)); }
        }
    }
}
