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

namespace Seminarski_PS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class GlavniProzor : Window
    {
        public GlavniProzor()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

        }
       
        private void TimKlik(object sender, RoutedEventArgs e)
        {
            TimoviProzor objTimoviProzor = new TimoviProzor();
            this.Visibility = Visibility.Hidden;
            objTimoviProzor.Show();
        }

        private void IzadjiMW(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void RezultatiKlik_Click(object sender, RoutedEventArgs e)
        {
            RezultatiWindow objRezultatiWindow = new RezultatiWindow();
            this.Visibility = Visibility.Hidden;
            objRezultatiWindow.Show();
        }

        private void IgraciButton(object sender, RoutedEventArgs e)
        {
            UnosIgracaWindow objUnosIgracaWindow = new UnosIgracaWindow();
            this.Visibility = Visibility.Hidden;
            objUnosIgracaWindow.Show();
        }

        private void TrenerClck(object sender, RoutedEventArgs e)
        {
            TrenerWindow objTrenerWindow = new TrenerWindow();
            this.Visibility = Visibility.Hidden;
            objTrenerWindow.Show();
        }

        private void StadionClck(object sender, RoutedEventArgs e)
        {
            StadionWindow objStadionWindow = new StadionWindow();
            this.Visibility = Visibility.Hidden;
            objStadionWindow.Show();
        }

        private void TransferMarketWindow(object sender, RoutedEventArgs e)
        {
            TransferMarketWindow objTransfer = new TransferMarketWindow();
            this.Visibility = Visibility.Hidden;
            objTransfer.Show();
        }
    }
}
