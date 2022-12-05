using System;
namespace GestImmo.Models
{
    public class Pret
    {
        public int PretId { get; set; }

        public int apport { get; set; }

        public int mensualite { get; set; }

        public int duree { get; set; }

        public DateTime dateDebut { get; set; }

        public Pret()
        {

        }

        public Pret(int apport, int mensualite, int duree, DateTime dateDebut)
        {
            this.apport = apport;
            this.mensualite = mensualite;
            this.duree = duree;
            this.dateDebut = dateDebut;
        }

        public int calculerCapitalRestant()
        {
            DateTime today = DateTime.Today;
            int diffMois = ((today.Year - this.dateDebut.Year) * 12) + today.Month - this.dateDebut.Month;
            int capitalRestant = 0;

            if (diffMois < this.duree)
            {
                capitalRestant = (this.duree - diffMois) * mensualite;
            }

            return capitalRestant;
        }
    }
}

