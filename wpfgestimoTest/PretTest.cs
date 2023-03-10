
using wpfgestimo.Data.Models;

namespace wpfgestimoTest
{
    [TestClass]
    public class PretTest
    {
        [TestMethod]
        public void TestCalculerCapitalRestant()
        {
            // Nouveau pret - Today
            int mensualiteToday = 500;
            int dureeToday = 10;
            Pret pretToday = new Pret(10000, mensualiteToday, dureeToday, DateTime.Today);
            int capitalRestantToday = pretToday.calculerCapitalRestant();
            Assert.AreEqual(mensualiteToday * dureeToday, capitalRestantToday);

            // Pret terminé - Ended
            DateTime dateEnded = new DateTime(2010, 01, 22);
            Pret pretEnded = new Pret(10000, mensualiteToday, dureeToday, dateEnded);
            int capitalRestantEnded = pretEnded.calculerCapitalRestant();
            Assert.AreEqual(0, capitalRestantEnded);
        }
    }
}