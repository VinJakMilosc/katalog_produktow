using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace katalog_produktow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Produkt> produkty = new List<Produkt>();
        public MainWindow()
        {
            InitializeComponent();
            KategorieComboBox.ItemsSource = new string[] { "Elektronika", "Odzież", "Książki", "Meble" };
            KategorieComboBox.SelectedIndex = 0;
            produkty. Add(new Produkt { Nazwa = "Laptop", Cena = 3000, Ilosc = 5, Kategoria = "Elektronika" });
            produkty.Add(new Produkt { Nazwa = "Koszula", Cena = 100, Ilosc = 10, Kategoria = "Odzież" });
            ListaProduktow.ItemsSource = produkty;
        }

        private void Oblicz(object sender, RoutedEventArgs e)
        {
            //string stringcena = CenaTextBoxa.Text;
            //int cena = int.Parse(stringcena);

            //string stringilosc = IloscTextBoxa.Text;
            //int ilosc = int.Parse(stringilosc);

            //if (cena < 1 || ilosc < 1)
            //{
            //    MessageBox.Show("Cena i ilość muszą być większe niż zero.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //else
            //{
            //    int wynik = cena * ilosc;
            //    WynicBlock.Text = $"Wynik: {wynik}";

            if (!double.TryParse(CenaTextBoxa.Text, out double cena))
            {
                WynicBlock.Text = "Niepoprawna wartość ceny";
                return;
            }

            if (!int.TryParse(IloscTextBoxa.Text, out int ilosc))
            {
                WynicBlock.Text = "Nie poprawna wartość ilości";
                return;
            }

            double wartoscZamowienia = cena * ilosc;

            if (PromocjeCheckBox.IsChecked == true)
            {
                wartoscZamowienia *= 0.9;
            }


            WynicBlock.Text = NazwaTextBoxa.Text + " " + wartoscZamowienia.ToString() + " " + ilosc + " " + KategorieComboBox.SelectedItem as string;




        }
    }
}