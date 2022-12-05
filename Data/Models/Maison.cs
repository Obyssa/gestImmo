using System;
namespace GestImmo.Models
{
    public class Maison : Habitable
    {
        public int MaisonId { get; set; }

        public Maison()
        {

        }

        public Maison(string nom, int valeur, string adresse, int surface, int nbPieces, int nbChambres, int nbCaves, int nbParking)
            : base(nom, valeur, adresse, surface, nbPieces, nbChambres, nbCaves, nbParking)
        {
        }
    }
}

