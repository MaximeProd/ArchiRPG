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
			var randomCombat = randomCustom.GetPourcentage(1, 100);

			Joueur = joueur;
			Mob = new Mob(joueur);
			Mob.AfficherStats();

			bool joueurCommence = false;
			if (randomCombat <= 65)
				joueurCommence = true;

			LancerCombat(joueurCommence);
		}

		void LancerCombat(bool joueurCommence)
		{
			while (Joueur.IsAlive() && Mob.IsAlive())
			{
				if (Joueur.IsAlive() && joueurCommence)
				{
					Console.WriteLine("Vous attaquez le mob");
					Joueur.Attaquer(Mob);
					Mob.AfficherStats();
				}
				if (Mob.IsAlive() && !joueurCommence)
				{
					Console.WriteLine("Le mob vous marrave");
					Mob.Attaquer(Joueur);
					Joueur.AfficherStats();
					Thread.Sleep(1000);
				}
				joueurCommence = !joueurCommence;
			}
		}

	}
}
