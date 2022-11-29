using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArchiRPG.Interface;

namespace ArchiRPG
{
	internal class RencontreMaitreArme : IRencontre
	{
		public Joueur Joueur { get; set; }

		public Joueur LancerRencontre(Joueur joueur)
		{
			Console.WriteLine("\nVous rencontrez le maitre d'arme !");
			Insulter();

			var leveling = new Leveling();
			joueur = leveling.MonterNiveau(joueur);

			return joueur;
		}

		public void Insulter(){
			Random rnd = new Random();
			string[] phrases = { "En garde, espèce de vieille p*** dégarnie !", 
						"HAHA, Sire ! Je vous attends ! À moins que vous préfériez que l’on dise partout que le roi est une petite pédale qui pisse dans son froc à l’idée de se battre !",
						"JE NE MANGE PAS DE GRAINES !", 
						"En garde, ma biquette ! Je vais vous découper le gras du c**, ça vous fera ça de moins à trimbaler !", 
						"Quand on est idiot, on plante des carottes on ne s'occupe pas de sécurité !",
						"Du nerf, mon lapinou !… Vous allez vous faire tailler le zizi en pointe !",
						"Mais allez-y bon sang, magnez-vous le fion, espèce de grosse dinde !" };
			
			int insulteIndex = rnd.Next(phrases.Length);

			Console.WriteLine(phrases[insulteIndex]);
		}
	}
}
