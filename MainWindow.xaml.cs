using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace grafika_kartkowka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Zdjecia> fotografie;
        private int licznik = 0;
        private string nowy_opis = "";
        public MainWindow()
        {
            InitializeComponent();
            przygDane();
        }

        private void poprzedniBut_Click(object sender, RoutedEventArgs e)
        {
            licznik--;
            if (licznik < 0)
            {
                licznik = fotografie.Count - 1;
            }
            zdjecieImage.Source = fotografie[licznik].getZdjecie();
            edytujOpis.Text = fotografie[licznik].getOpis();

        }

        private void nastepnyBut_Click(object sender, RoutedEventArgs e)
        {
            licznik++;
            if(licznik > fotografie.Count-1)
            {
                licznik = 0;
            }
            zdjecieImage.Source = fotografie[licznik].getZdjecie();
            edytujOpis.Text = fotografie[licznik].getOpis();
        }

        private void zatwierdzNowyOpisBut_Click(object sender, RoutedEventArgs e)
        {
            nowy_opis = edytujOpis.Text;
            if(nowy_opis != fotografie[licznik].getOpis())
            {
                fotografie[licznik].opis = nowy_opis;
            }
            else
            {
                MessageBox.Show("Podaj inny opis, ten już został przypisany do tego obiektu!!!");
            }
        }

        private void przygDane()
        {
            fotografie = new List<Zdjecia>();
            fotografie.Add(new Zdjecia("Slodki piesek", "piesek.jpg"));
            fotografie.Add(new Zdjecia("Uwaga, zly pies", "piesek2.jpg"));
            fotografie.Add(new Zdjecia("Zaraz Cie zlapie!", "piesek3.jpg"));
            fotografie.Add(new Zdjecia("Przytul mnie", "piesek4.jpg"));
            fotografie.Add(new Zdjecia("Jestem uroczy, prawda?", "piesek5.jpg"));
        }
    }
}
