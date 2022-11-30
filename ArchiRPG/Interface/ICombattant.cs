using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiRPG.Interface
{
    internal interface ICombattant
    {
        public int Armure { get; set; }
        public int PointDeVie { get; set; }
        public int Force { get; set; }

        public void Attaquer(ICombattant combattant);
        public void AfficherStats();
        public bool IsAlive();
    }

}
