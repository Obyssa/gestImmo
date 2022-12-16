using GestImmo.Data.DAL;
using GestImmo.Data.Models;
using GestImmo.Models;
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
    /// Logique d'interaction pour ListViewBien.xaml
    /// </summary>
    public partial class ListViewBien : Page, iObserver
    {


        public ListViewBien()
        {
            InitializeComponent();
            this.refreshList();
        }
        void refreshList()
        {
            GestImmoContext ctx = GestImmoContext.getInstance();
            this.ListView.Items.Clear();

            foreach (Bien bien in ctx.Biens)
            {
                this.ListView.Items.Add(bien.Nom);
            }
        }
        public void update()
        {
            refreshList();
        }

        
    }
}
