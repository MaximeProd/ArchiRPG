using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiRPG
{
	internal class Leveling
	{
		public Joueur MonterNiveau(Joueur joueur){
			joueur.Niveau += 1;
			return joueur;
		}
	}
}
