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

namespace wpfgestimo.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour ajouterAppartement.xaml
    /// </summary>
    public partial class ajouterAppartement : Page, iObservable
    {
        public List<iObserver> Observers { get; set; }
        public ajouterAppartement()
        {
            InitializeComponent();
            this.Observers = new List<iObserver>();
        }
        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxNom.Text != "" && txtBoxValeur.Text != "" && txtBoxAdresse.Text != "" && txtBoxSurface.Text != "" && txtBoxPiece.Text != "" && txtBoxChambre.Text != "" && txtBoxCave.Text != "" && txtBoxParking.Text != "" && txtBoxEtage.Text != "")
            {
                bool verifChauff = false;
                if (cbBoxBien.SelectedIndex == 0)
                {
                    verifChauff = true;
                }
                bool ascenseur = false;
                if (cbBoxAscenseur.SelectedIndex == 0)
                {
                    ascenseur = true;
                }
                Appartement unAppart = new Appartement(txtBoxNom.Text, int.Parse(txtBoxValeur.Text), txtBoxAdresse.Text, int.Parse(txtBoxSurface.Text), int.Parse(txtBoxPiece.Text), int.Parse(txtBoxChambre.Text), int.Parse(txtBoxCave.Text), int.Parse(txtBoxParking.Text), int.Parse(txtBoxEtage.Text), ascenseur, verifChauff);
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Biens.Add(unAppart);
                ctx.SaveChanges();

            }
            else
            {
                MessageBox.Show("L'un des paramètres est vide.");
            }
            this.notifyObservers();
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
