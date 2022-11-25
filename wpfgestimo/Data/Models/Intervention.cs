using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfgestimo.Data.Models
{
    public class Intervention
    {
        public int InterventionId { get; set; }
        public DateTime Date { get; set; }
        public double MontantHT { get; set; }
        public string Informations { get; set; }
        public List<Prestataire> Prestataires { get; set; }
        public Bien Bien { get; set; }
    }
}
