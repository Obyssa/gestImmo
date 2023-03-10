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
using wpfgestimo.Views;

namespace wpfgestimo.Views
{
    /// <summary>
    /// Logique d'interaction pour NavigationView.xaml
    /// </summary>
    public partial class NavigationView : Page
    {
        public NavigationView()
        {
            InitializeComponent();
            this.frmMain.Navigate(new HomeView());
        }

        private void BtnAccueil_Click(object sender, RoutedEventArgs e)
        {
            this.frmMain.Navigate(new HomeView());
        }

        private void BtnBiens_Click(object sender, RoutedEventArgs e)
        {
            this.frmMain.Navigate(new BienView());
        }

        private void BtnPrets_Click(object sender, RoutedEventArgs e)
        {
            this.frmMain.Navigate(new PretView());
        }

        private void BtnPrestataires_Click(object sender, RoutedEventArgs e)
        {
            this.frmMain.Navigate(new PrestataireView());
        }
    }
}
