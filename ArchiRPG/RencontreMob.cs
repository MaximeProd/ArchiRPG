using ArchiRPG.Helper;
using ArchiRPG.Interface;

namespace ArchiRPG
{
    internal class RencontreMob : IRencontre
	{
		public Joueur Joueur { get; set; }
		public Mob Mob { get; set; }

		public void LancerRencontre(Joueur joueur)
		{
			Console.WriteLine("\nVous rencontrez un mob !");
			var randomCustom = new RandomLibrary();
			var randomCombat = randomCustom.getPourcentage(1, 100);

			Joueur = joueur;
			Mob = new Mob();

			bool joueurCommence = false;
			if (randomCombat <= 65)
			{
				joueurCommence = true;
			}
			LancerCombat(joueurCommence);
		}

		void LancerCombat(bool joueurCommence)
		{
			while(!Joueur.IsAlive() || !Mob.IsAlive())
			{
				if(Joueur.IsAlive() || joueurCommence)
				{
					Console.WriteLine("Vous attaquez le mob");
					Joueur.Attaquer(Mob);
					Joueur.afficherStats();
				}
				if(Mob.IsAlive())
				{
					Console.WriteLine("Le mob vous marrave");
					Mob.Attaquer(Joueur);
					Mob.afficherStats();
				}

				joueurCommence = false;
			}
		}

	}
}
