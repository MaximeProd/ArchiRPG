using ArchiRPG.Factory;

namespace ArchiRPG
{
    internal class Tour
	{
		public void LancerEvenement(Joueur joueur, int nbTour){
			Console.WriteLine("\n\n  Le tour n°" + nbTour + " commence !");
			var rencontreFactory = new RencontreFactory();
			var rencontre = rencontreFactory.CreerRencontre();
			rencontre.LancerRencontre(joueur);

			Console.WriteLine("Vos stats à la fin de ce tour :");
			joueur.afficherStats();
		}
	}
}
