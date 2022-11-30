using ArchiRPG.Helper;
using ArchiRPG.Interface;

namespace ArchiRPG
{
    internal class RencontreMerlin : IRencontre
	{
		public Joueur Joueur { get; set; }

		public void LancerRencontre(Joueur joueur)
		{
			Console.WriteLine("\nVous rencontrez Merlin !");

			var randomCustom = new RandomLibrary();
			var pourcentHeal = randomCustom.getPourcentage(1, 100);
			
			Console.WriteLine("Merlin va vous rendre " + pourcentHeal + "% de votre vie !");

			var healing = new Healing();
			healing.RestorePv(joueur, pourcentHeal);
			PhraseMerlin(pourcentHeal);
		}
		
		private void PhraseMerlin(int pourcent){
			if(pourcent < 10)
				Console.WriteLine("La boutique est fermée, adressez-vous à la concurrence.");
			else if(pourcent >= 10 && pourcent < 40)
				Console.WriteLine("Moi j'ai vomi deux fois mais c'est moi qu'ai ramassé  !");
			else if( pourcent >= 40 && pourcent < 85)
				Console.WriteLine("Moi, je dis que c'est magique à cause des merdes qui pendouillent, mais ça se trouve, c'est pas ça...");
			else if(pourcent >= 85)
				Console.WriteLine("Attendez, je veux être là quand vous lui mettez une chasse !");
		}
	}
}
