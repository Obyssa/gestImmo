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
        public GererBienForm()
        {
            InitializeComponent();
        }
        private void cbBoxBien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbBoxBien.SelectedIndex == 0)
            {
                this.frmAjout.Navigate(new ajouterBien());
            }
            if (cbBoxBien.SelectedIndex == 1)
            {
                this.frmAjout.Navigate(new ajouterMaison());
            }
            if (cbBoxBien.SelectedIndex == 2)
            {
                this.frmAjout.Navigate(new ajouterAppartement());
            }
        }
    }
}
