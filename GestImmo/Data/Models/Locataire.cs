using System;
namespace GestImmo.Models
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
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            this.Profession = profession;
        }
    }
}

