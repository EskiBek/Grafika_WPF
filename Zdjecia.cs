using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace grafika_kartkowka
{
    public class Zdjecia
    {
        public string opis { get; set; }
        private string imageZdj { get; set; }

        public Zdjecia(string opis, string imageZdj)
        {
            this.opis = opis;
            this.imageZdj = imageZdj;
        }

        public BitmapImage getZdjecie()
        {
            return new BitmapImage(new Uri(imageZdj, UriKind.Relative));
        }

        public string getOpis()
        {
            return this.opis;
        }
    }
}
