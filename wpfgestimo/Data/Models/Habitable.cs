using System;

namespace wpfgestimo.Data.Models
{
    public abstract class Habitable : Bien
    {
        public int HabitableId { get; set; }
        public int nbPieces { get; set; }
        public int nbChambres { get; set; }
        public int nbCaves { get; set; }
        public int nbParking { get; set; }

        public Habitable()
        {

        }

        public Habitable(string nom, int valeur, string adresse, int surface, int nbPieces, int nbChambres, int nbCaves, int nbParking)
            : base(nom, valeur, adresse, surface)
        {
            this.nbPieces = nbPieces;
            this.nbChambres = nbChambres;
            this.nbCaves = nbCaves;
            this.nbParking = nbParking;
        }
    }
}

