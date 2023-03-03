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
    /// Logique d'interaction pour ajouterBien.xaml
    /// </summary>
    public partial class ajouterBien : Page, iObservable
    {
        public List<iObserver> Observers { get; set; }

        public ajouterBien()
        {
            InitializeComponent();
            this.Observers = new List<iObserver>();

        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxNom.Text != "" && txtBoxValeur.Text != "" && txtBoxAdresse.Text != "" && txtBoxSurface.Text != "")
            {
                Bien unbien = new Box(txtBoxNom.Text, int.Parse(txtBoxValeur.Text), txtBoxAdresse.Text, int.Parse(txtBoxSurface.Text));
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Biens.Add(unbien);
                ctx.SaveChanges();
                Log.Information("Nouveau box crée");
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
