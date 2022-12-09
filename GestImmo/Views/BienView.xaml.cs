using GestImmo.Data.DAL;
using GestImmo.Data.Models;
using GestImmo.Models;
using GestImmo.Views.Forms;
using GestImmo.Views.SubViews;
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

namespace GestImmo.Views
{
    /// <summary>
    /// Logique d'interaction pour BienView.xaml
    /// </summary>
    public partial class BienView : Page, iObserver
    {
        GestImmoContext ctx = GestImmoContext.getInstance();
        public BienView()
        {
            InitializeComponent();
            this.refreshList();
        }
        void refreshList()
        {
            GestImmoContext ctx = GestImmoContext.getInstance();
            this.ListViewBien.Items.Clear();
            ///Bien unbien = new Box("Oui", 50, "abc", 50);
            ///gestImmo.Biens.Add(unbien);
            foreach (Bien bien in ctx.Biens)
            {
                this.ListViewBien.Items.Add(bien.Nom);
            }
        }
        public void update()
        {
            refreshList();
        }
        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            this.frmAutre.Navigate(new BienView());
        }



        /*private void ListViewBien_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            ModifierBien objModifierBien = new ModifierBien();
            this.frmAutre.Navigate(objModifierBien);
            string az = (string)ListViewBien.SelectedItems[0];
            foreach (Bien bien in ctx.Biens)
            {
                if (bien.Nom == az)
                {
                    objModifierBien.txtBoxNom.Text = bien.Nom;
                    objModifierBien.txtBoxValeur.Text = (bien.Valeur).ToString();
                    objModifierBien.txtBoxAdresse.Text = bien.Adresse;
                    objModifierBien.txtBoxSurface.Text = (bien.Surface).ToString();
                }
            }
        }*/
    }
        
}
