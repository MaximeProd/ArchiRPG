using ArchiRPG.Interface;

namespace ArchiRPG
{
    internal class RencontreMob : IRencontre
	{
		public Joueur Joueur { get; set; }
		public Mob Mob { get; set; }

		public Joueur LancerRencontre(Joueur joueur)
		{
			Console.WriteLine("\nVous rencontrez un mob !");
			// todo : implémenter
			return joueur;
		}
	}
}
