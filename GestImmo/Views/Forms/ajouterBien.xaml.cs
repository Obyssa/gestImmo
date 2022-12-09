using GestImmo.Data.DAL;
using GestImmo.Data.Models;
using GestImmo.Models;
using GestImmo.Views.Forms;
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

namespace GestImmo.Views.SubViews
{
    /// <summary>
    /// Logique d'interaction pour ajouterBien.xaml
    /// </summary>
    public partial class ajouterBien : Page , iObservable
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
                GestImmoContext ctx = GestImmoContext.getInstance();
                ctx.Biens.Add(unbien);
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
