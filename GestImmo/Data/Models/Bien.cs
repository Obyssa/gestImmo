using System;
using System.Collections.Generic;

namespace GestImmo.Models
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
            this.Nom = nom;
            this.Valeur = valeur;
            this.Adresse = adresse;
            this.Surface = surface;
            this.Bails = new List<Bail>();
        }
    }
}

