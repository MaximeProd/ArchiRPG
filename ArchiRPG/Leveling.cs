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
			// augmentation du niveau
			joueur.Niveau += 1;
			
			// reprend 10% de ses pvs
			var healing = new Healing();
			joueur = healing.RestorePv(joueur, 10);
			
			// 3 nouveaux points de compétence
			var attribution = new AttribuerCompetence();
			joueur = attribution.AttribuerCompetence(joueur, 3);
			
			return joueur;
		}
	}
}
