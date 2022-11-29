using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArchiRPG.Interface;

namespace ArchiRPG
{
	internal class Joueur : ICombattant
	{
		public int Armure { get; set; }
		public int PointDeVie { get; set; }
		public int Force { get; set; }

		public int Niveau { get; set; }
		public int PointDeVieMax { get; set; }

		public void Attaquer(ICombattant combattant)
		{
			throw new NotImplementedException();
		}

		public void afficherStats()
		{
				Console.WriteLine("Voilà vos stats actuelles :" +
				    "\n\t Niveau : " + this.Niveau +
				    "\n\t Force : " + this.Force +
				    "\n\t Armure : " + this.Armure +
				    "\n\t Points de vie  : " + this.PointDeVie
			);
		}
	}
}
