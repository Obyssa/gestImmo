﻿using GestImmo.Data.DAL;
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
using Serilog;

namespace GestImmo.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour ajouterMaison.xaml
    /// </summary>
    public partial class ajouterMaison : Page, iObservable
    {
        public List<iObserver> Observers { get; set; }
        public ajouterMaison()
        {
            InitializeComponent();
            this.Observers = new List<iObserver>();
        }
        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxNom.Text != "" && txtBoxValeur.Text != "" && txtBoxAdresse.Text != "" && txtBoxSurface.Text != "" && txtBoxPiece.Text != "" && txtBoxChambre.Text != "" && txtBoxCave.Text != "" && txtBoxParking.Text != "")
            {
                Maison uneMaison = new Maison(txtBoxNom.Text, int.Parse(txtBoxValeur.Text), txtBoxAdresse.Text, int.Parse(txtBoxSurface.Text), int.Parse(txtBoxPiece.Text), int.Parse(txtBoxChambre.Text), int.Parse(txtBoxCave.Text), int.Parse(txtBoxParking.Text));
                GestImmoContext ctx = GestImmoContext.getInstance();
                ctx.Biens.Add(uneMaison);
                ctx.SaveChanges();
                Log.Information("Nouvel maison crée");
            }
            else
            {
                MessageBox.Show("L'un des champs n'est pas remplis.");
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
