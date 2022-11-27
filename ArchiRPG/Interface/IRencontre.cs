using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiRPG.Interface
{
    internal interface IRencontre
    {
        Joueur Joueur { get; set; }

        public void LancerRencontre(Joueur joueur);

    }
}
