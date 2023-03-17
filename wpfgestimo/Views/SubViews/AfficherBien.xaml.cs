using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    public partial class AfficherBien : Page, iObservable  
    {
        public List<iObserver> Observers { get; set; }

        ImmoContext ctx = ImmoContext.getInstance();
        Bien bien;
        
        public AfficherBien(int id)
        {
            InitializeComponent();
            this.bien = ctx.Biens.Find(id)!;
            this.Observers = new List<iObserver>();

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
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Voulez-vous vraiment supprimer se bien.", "Confirmation Suppression", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                this.ctx.Biens.Remove(bien);
                this.ctx.SaveChanges();
                this.notifyObservers();
            }
        }
        public void notifyObservers()
        {
            foreach (iObserver obs in Observers)
            {
                obs.update();
            }
        }
    }      
}
