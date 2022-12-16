using GestImmo.Data.DAL;
using GestImmo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GestImmo.Controllers
{
    class ContrellerFinance
    {
        public int calculerRentabiliteNetMensuelGlobal()
        {
            GestImmoContext ctx = GestImmoContext.getInstance();
            List<Bien> biens = ctx.Biens.ToList();

            int revenuGlobal = 0;

            foreach (Bien bien in biens)
            {
                revenuGlobal = revenuGlobal + bien.calculerRentabiliteNetMensuel();
            }

            return revenuGlobal;
        }
    }
}
