using System;

namespace wpfgestimo.Data.Models
{
    public class Appartement : Habitable
    {
        public int AppartementId { get; set; }

        public int Etage { get; set; }

        public bool Assenceur { get; set; }

        public bool ChauffCommun { get; set; }

        public Appartement()
        {

        }
        public Appartement(string nom, int valeur, string adresse, int surface, int nbPieces, int nbChambres, int nbCaves, int nbParking, int etage, bool assenceur, bool chauffCommun)
            : base(nom, valeur, adresse, surface, nbPieces, nbChambres, nbCaves, nbParking)
        {
            Etage = etage;
            Assenceur = assenceur;
            ChauffCommun = chauffCommun;
        }
    }
}

