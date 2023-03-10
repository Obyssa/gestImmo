using System;
using System.Collections.Generic;

namespace wpfgestimo.Data.Models
{
    public abstract class Bien
    {
        public int BienId { get; set; }
        public string Nom { get; set; }
        public int Valeur { get; set; }
        public string Adresse { get; set; }
        public int Surface { get; set; }
        public List<Bail> Bails { get; set; }
        public List<Intervention> Interventions { get; set; }
        public Pret? Pret { get; set; }

        public Bien()
        {

        }

        public Bien(string nom, int valeur, string adresse, int surface)
        {
            Nom = nom;
            Valeur = valeur;
            Adresse = adresse;
            Surface = surface;
            Bails = new List<Bail>();
        }
        public int calculerRentabiliteNetMensuel()
        {
            int montantPret = 0;
            int loyer = 0;
            // Permet de fixer la mesualiter du pret
            if(this.Pret != null)
            {
                montantPret = this.Pret.mensualite;
            }
            // Permet de fixer le loyer
            if(this.Bails.Count > 0)
            {
                foreach(Bail bail in this.Bails)
                {
                    if(bail.DateFin == null)
                    {
                        loyer = bail.Loyer;
                        break;
                    }
                }
            }
            return loyer - montantPret;
        }
    }
}

