using ArchiRPG.Factory;

namespace ArchiRPG
{
    internal class Tour
	{
		public void LancerEvenement(Joueur joueur){
			var rencontreFactory = new RencontreFactory();
			var rencontre = rencontreFactory.CreerRencontre();
			rencontre.LancerRencontre(joueur);
		}
	}
}
