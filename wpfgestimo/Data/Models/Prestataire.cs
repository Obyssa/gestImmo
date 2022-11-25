using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfgestimo.Data.Models
{
    public class Prestataire
    {
        public int PrestataireId { get; set; }
        public string RaisonSociale { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public List<Intervention> Interventions { get; set; }
    }
}
