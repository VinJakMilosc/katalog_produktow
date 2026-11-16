using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace katalog_produktow
{
    public class Produkt : INotifyPropertyChanged
    {
        public string Nazwa { get; set; } = "";
        private double cena;
        public double Cena
        {
            //jeśli ktoś chce odczytać cenę, zwracamy jej wartość
            get { return cena; }
            // Cena nie może być ujemna, więc jeśli ktoś spróbuje ustawić wartość ujemną, ustawiamy ją na 0
            set { cena = value < 0 ? 0 : value; Zmiana(nameof(Cena)); }
        }
        private int ilosc;
        public int Ilosc
        {
            get { return ilosc; }
            set { ilosc = value < 0 ? 0 : value; Zmiana(nameof(Ilosc)); }
        }
        public string Kategoria { get; set; } = "";
       
        public double WartoscZamowienia
        {
            get { return Cena * Ilosc; }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        private void Zmiana(string nazwaWlasciwosci)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nazwaWlasciwosci));
        }
    }
}
