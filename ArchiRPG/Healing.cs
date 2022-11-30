namespace ArchiRPG
{
    internal class Healing
    {
        public void RestorePv(Joueur joueur, int pourcent)
        {
            double pdv = joueur.PointDeVie + (joueur.PointDeVieMax * pourcent / 100);

            if (pdv > joueur.PointDeVieMax)
                pdv = joueur.PointDeVieMax;

            joueur.PointDeVie = (int)Math.Round(pdv);
        }
    }
}
