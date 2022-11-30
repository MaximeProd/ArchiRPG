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
            InitialiserPerso();
            CreationPerso();
            joueur.afficherStats();

            //lancement des 20 tours
            for (int i = 0; i < 20; i++)
            {
                LancerTour(i + 1);
                // on attend quelques secondes pour laisser à l'utilisateur le temps de lire ce qu'il s'est passé
                System.Threading.Thread.Sleep(5000);
            }
        }

        private void CreationPerso()
        {
            var attribution = new AttributionCompetence();
            attribution.AttribuerCompetence(joueur, 12);
        }

        private void InitialiserPerso()
        {
            joueur = new Joueur()
            {
                Niveau = 1,
                Force = 15,
                Armure = 15,
                PointDeVie = 30,
                PointDeVieMax = 30
            };
        }

        private void LancerTour(int nbTour) {
            var tour = new Tour();
            tour.LancerEvenement(joueur, nbTour);
        }
    }
}
