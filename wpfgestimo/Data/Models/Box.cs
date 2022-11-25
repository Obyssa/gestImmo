using System;

namespace wpfgestimo.Data.Models
{
    public class Box : Bien
    {
        public int BoxId { get; set; }

        public Box()
        {

        }

        public Box(string nom, int valeur, string adresse, int surface) : base(nom, valeur, adresse, surface)
        {

        }
    }
}

