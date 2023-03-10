using wpfgestimo.Data.Models;

namespace wpfgestimoTest
{
    [TestClass]
    public class BienTest
    {
        [TestMethod]
        public void TestCalculerRentabiliteNetMensuel()
        {
            // Nouveau Bails
            int loyer = 330;
            DateTime dateDebut = DateTime.Today;
            Bail bail = new Bail(loyer, dateDebut, null);
            Bail bail1 = new Bail(loyer, dateDebut, null);

            // Nouveau Prets
            int apport = 150;
            int mensualite = 200;
            int duree = 5;
            DateTime dateDebutPret = DateTime.Today;
            Pret pret1 = new Pret(apport, mensualite, duree, dateDebut);
            Pret pret2 = new Pret(apport, mensualite, duree, dateDebut);

            // Nouveau Box
            string nom = "Box";
            int valeur = 1500;
            string adresse = "221 route de sbah";
            int surface = 15;
            
        }
    }
}