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
    public partial class BienView : Page
    {
        GestImmoContext ctx = GestImmoContext.getInstance();
        private ListViewBien listViewBien;
        public BienView()
        {
            InitializeComponent();
            this.listViewBien = new ListViewBien();
            this.frmList.Navigate(this.listViewBien);
        }
        
        
        
        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            this.frmAutre.Navigate(new GererBienForm(this.listViewBien));
        }



        private void ListView_Click(object sender, MouseButtonEventArgs e)
        {
            ModifierBien objModifierBien = new ModifierBien();
            this.frmAutre.Navigate(new ModifierBien());
            
        }

    }
        
}
