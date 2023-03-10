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
    /// Logique d'interaction pour MaisonDetailView.xaml
    /// </summary>
    public partial class MaisonDetailView : Page
    {
        private Bien bien;
        public MaisonDetailView(Bien bien)
        {
            InitializeComponent();
            this.bien = bien;
            this.type.Text = "Maison";
            this.nom.Text = bien.Nom;
            this.valeur.Text = bien.Valeur.ToString() + " €";
            this.adresse.Text = bien.Adresse;
            this.surface.Text = bien.Surface.ToString() + " m²";
            this.bien = bien;
        }

    }
}
