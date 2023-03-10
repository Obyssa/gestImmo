using wpfgestimo.Data.Models;
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
using wpfgestimo.Views.Forms;
using wpfgestimo.Views.SubViews;

namespace wpfgestimo.Views
{
    /// <summary>
    /// Logique d'interaction pour BienView.xaml
    /// </summary>
    public partial class BienView : Page
    {
        ImmoContext ctx = ImmoContext.getInstance();
        private ListBienView ListBienView;
        public BienView()
        {
            InitializeComponent();
            this.ListBienView = new ListBienView(frmAutre);
            this.frmList.Navigate(this.ListBienView);
        }



        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            this.frmAutre.Navigate(new GererBienForm((iObserver)this.ListBienView));
        }



        

    }
}
