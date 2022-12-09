using System;
namespace GestImmo.Models
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
            this.Etage = etage;
            this.Assenceur = assenceur;
            this.ChauffCommun = chauffCommun;
        }
    }
}

