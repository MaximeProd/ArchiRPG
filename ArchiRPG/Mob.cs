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

		public void Attaquer(ICombattant combattant)
		{
            var randomCustom = new RandomLibrary();
            var resultDes = randomCustom.getDesDouze();
            var ptsDegat = resultDes + combattant.Force - combattant.Armure;
            var resultAttaque = ptsDegat - combattant.PointDeVie;
            combattant.PointDeVie -= ptsDegat;
    }
    public void afficherStats()
    {
        Console.WriteLine("Voilà les stats du mob :" +
            "\n\t Force : " + this.Force +
            "\n\t Armure : " + this.Armure +
            "\n\t Points de vie  : " + this.PointDeVie
        );
    }
		public bool IsAlive()
		{
			return PointDeVie > 0;
		}
	}
}
