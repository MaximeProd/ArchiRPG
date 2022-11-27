using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArchiRPG.Helper;
using ArchiRPG.Interface;

namespace ArchiRPG.Factory
{
  internal class RencontreFactory
    {
      
      public IRencontre CreerRencontre()
      {
      // TODO : Instancier une rencontre
        var selected = RandomLibrary.getPourcentages(
          (typeof(RencontreMaitreArme), 25),
          (typeof(RencontreMerlin), 25),
          (typeof(RencontreMob), 50)
        );

				return (IRencontre)Activator.CreateInstance(selected.GetType(),new object[] { });
      }
    }
}
