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
                // TODO implementer le metier du tour
                LancerTour();
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

        private void LancerTour() {
            var tour = new Tour();
            tour.LancerEvenement(joueur);
        }
    }
}
