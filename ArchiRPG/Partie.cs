namespace ArchiRPG
{
    internal class Partie
    {
        private Joueur joueur { get; set; }

        public void StartPartie()
        {
            Console.WriteLine("Bonjour et bienvenue dans LE rpg !" +
                                "\nNous allons commencer par affecter vos 12 points de compétences.");
            // début de la partie
            joueur = new Joueur();
            CreationPerso();
            joueur.AfficherStats();

            //lancement des 20 tours
            for (int i = 0; i < 20; i++)
            {
                LancerTour(i + 1);
                if (!joueur.IsAlive())
                    break;

                // on attend quelques secondes pour laisser à l'utilisateur le temps de lire ce qu'il s'est passé
                Thread.Sleep(5000);
            }

            if (!joueur.IsAlive())
            {
                Console.WriteLine("Vous vous êtes fait marravé !");
                return;                
            }

            Console.WriteLine("Bravo ! Vous les avez bien marravé !");
            joueur.AfficherStats();
        }

        private void CreationPerso()
        {
            var attribution = new AttributionCompetence();
            attribution.AttribuerCompetence(joueur, 12);
        }

        private void LancerTour(int nbTour) {
            var tour = new Tour();
            tour.LancerEvenement(joueur, nbTour);
        }
    }
}
