﻿using ArchiRPG.Helper;
using ArchiRPG.Interface;

namespace ArchiRPG
{
    internal class RencontreMerlin : IRencontre
	{
		public Joueur Joueur { get; set; }

		public Joueur LancerRencontre(Joueur joueur)
		{
			Console.WriteLine("\nVous rencontrez Merlin !");

			var randomCustom = new RandomLibrary();
			// on part du principe que merlin rend au moins 50% de la vie du joueur 
			var pourcentHeal = randomCustom.getPourcentage(50, 100);
			Console.WriteLine("Merlin va vous rendre " + pourcentHeal + "% de votre vie !");

			var healing = new Healing();
			joueur = healing.RestorePv(joueur, pourcentHeal);

			return joueur;
		}
	}
}
