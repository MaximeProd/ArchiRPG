using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArchiRPG.Helper;
using ArchiRPG.Interface;

namespace ArchiRPG
{
    internal class Mob : ICombattant
    {
        public int Armure { get; set; }
        public int PointDeVie { get; set; }
        public int Force { get; set; }

        public Mob(Joueur joueur)
        {
            Armure = Force = 12 + (2 * joueur.Niveau);
            PointDeVie = 25 + (2 * joueur.Niveau); ;
        }

        public void Attaquer(ICombattant defenseur)
        {
            var randomCustom = new RandomLibrary();
            var resultDes = randomCustom.GetDesDouze();
            var ptsDegat = resultDes + Force - defenseur.Armure;
            defenseur.PointDeVie -= ptsDegat;
        }

        public void AfficherStats()
        {
            Console.WriteLine("Voilà les stats du mob :" +
                "\n\t Force : " + this.Force +
                "\n\t Armure : " + this.Armure +
                "\n\t Points de vie  : " + (IsAlive() ? this.PointDeVie : 0)
            );
        }
        public bool IsAlive()
        {
            return PointDeVie > 0;
        }
    }
}
