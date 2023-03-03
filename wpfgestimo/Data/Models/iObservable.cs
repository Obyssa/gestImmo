using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfgestimo.Data.Models
{
    public interface iObservable
    {
        List<iObserver> Observers { get; set; }

        void notifyObservers()
        {

            foreach (iObserver obs in Observers)
            {
                obs.update();
            }
        }
    }
}
