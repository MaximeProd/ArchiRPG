using ArchiRPG.Interface;

namespace ArchiRPG
{
    internal class RencontreMerlin : IRencontre
	{
		public Joueur Joueur { get; set; }

		public Joueur LancerRencontre(Joueur joueur)
		{
			Console.WriteLine("\nVous rencontrez Merlin !");
			// todo : implémenter
			return joueur;
		}
	}
}
