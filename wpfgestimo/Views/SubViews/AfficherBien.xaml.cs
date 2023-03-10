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
using wpfgestimo.Data.Models;
using wpfgestimo.Views.Forms;

namespace wpfgestimo.Views.SubViews
{
    /// <summary>
    /// Logique d'interaction pour AfficherBien.xaml
    /// </summary>
    public partial class AfficherBien : Page
    {
        ImmoContext ctx = ImmoContext.getInstance();
        public AfficherBien(int id)
        {
            InitializeComponent();
            Bien bien = ctx.Biens.Find(id)!;

            if (bien is Box)
            {
                this.frmAfficher.Navigate(new BoxDetailView((Bien)bien));
            }
            else if (bien is Appartement)
            {
                this.frmAfficher.Navigate(new AppartDetailView((Appartement)bien));
            }
            else if (bien is Maison)
            {
                this.frmAfficher.Navigate(new MaisonDetailView((Bien)bien));
            }
        }

        private void btnModify_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSuppr_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
