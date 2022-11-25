using System;

namespace wpfgestimo.Data.Models
{
    public class Locataire
    {
        public int LocataireId { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public int Age { get; set; }

        public string Profession { get; set; }

        public Locataire()
        {

        }
        public Locataire(string nom, string prenom, int age, string profession)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Profession = profession;
        }
    }
}

