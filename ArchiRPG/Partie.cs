using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiRPG
{
	internal class Partie
	{
		private Joueur joueur { get; set; }

		public void StartPartie(){
			joueur = new Joueur()
			{
				Niveau = 1,
                Force = 15,
                Armure = 15,
				PointDeVie = 30,
				PointDeVieMax= 30
			};
			Console.WriteLine("Bonjour et bienvenue dans LE rpg !" + 
								"\nNous allons commencer par affecter vos 12 points de compétences.");
			CreationPerso();

			joueur.afficherStats();
		}

        private void CreationPerso(){
			var attribution = new AttributionCompetence();
			attribution.AttribuerCompetence(joueur, 12);
        }
    }
}
