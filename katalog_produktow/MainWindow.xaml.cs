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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Oblicz(object sender, RoutedEventArgs e)
        {
            string stringcena = CenaTextBoxa.Text;
            int cena = int.Parse(stringcena);

            string stringilosc = IloscTextBoxa.Text;
            int ilosc = int.Parse(stringilosc);

            if (cena < 1 || ilosc < 1)
            {
                MessageBox.Show("Cena i ilość muszą być większe niż zero.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                int wynik = cena * ilosc;
                WynicBlock.Text = $"Wynik: {wynik}";
            }
        }
    }
}