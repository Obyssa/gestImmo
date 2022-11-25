using System;
using System.Collections.Generic;
using System.Text;

namespace wpfgestimo.Data.Models
{
    public class Contrat
    {

        private int caution;
        private int loyer;
        private DateTime dateDebut;
        private DateTime dateFin;
        private List<Contrat> contratList;

        public Contrat(int caution, int loyer, DateTime dateDebut, DateTime dateFin, List<Contrat> contratList)
        {

            this.caution = caution;
            this.loyer = loyer;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.contratList = contratList;
        }


        public int Caution { get => caution; set => caution = value; }
        public int Loyer { get => loyer; set => loyer = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }

        public void AffichezContrat()
        {
            foreach (Contrat unElement in contratList)
            {
                Console.WriteLine(unElement);
            }
        }

    }
}
