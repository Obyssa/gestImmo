using GestImmo.Data.Models;
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

namespace GestImmo.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererBienForm.xaml
    /// </summary>
    public partial class GererBienForm : Page
    {
        
        private iObserver obs;
        public GererBienForm(iObserver obs)
        {
            InitializeComponent();
            this.obs = obs;
        }
        
        private void cbBoxBien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbBoxBien.SelectedIndex == 0)
            {
                ajouterBien box = new ajouterBien();
                box.Observers.Add(this.obs);
                this.frmAjout.Navigate(box);
            }
            if (cbBoxBien.SelectedIndex == 1)
            {
                ajouterMaison maison = new ajouterMaison();
                maison.Observers.Add(this.obs);
                this.frmAjout.Navigate(maison);
            }
            if (cbBoxBien.SelectedIndex == 2)
            {
                ajouterAppartement appartement = new ajouterAppartement();
                appartement.Observers.Add(this.obs);
                this.frmAjout.Navigate(appartement);
            }
        }

       
    }
}
