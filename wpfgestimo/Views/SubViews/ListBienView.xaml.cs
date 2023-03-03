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

namespace wpfgestimo.Views.SubViews
{
    /// <summary>
    /// Logique d'interaction pour ListBienView.xaml
    /// </summary>
    public partial class ListBienView : Page
    {
        public ListBienView()
        {
            InitializeComponent();
            this.refreshList();
        }

        void refreshList()
        {
            ImmoContext ctx = ImmoContext.getInstance();
            this.lstBiens.Items.Clear();

            foreach (Bien bien in ctx.Biens)
            {
                this.lstBiens.Items.Add(bien);
            }
        }

        private void lstBiens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ImmoContext ctx = ImmoContext.getInstance();

            foreach (Bien bien in ctx.Biens)
            {
                this.lstBiens.Items.Add(bien.Nom);
            }
        }
    }
}