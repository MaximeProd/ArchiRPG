namespace ArchiRPG
{
    internal class Healing
    {
        public void RestorePv(Joueur joueur, int pourcent)
        {
            decimal pdv = joueur.PointDeVie + (joueur.PointDeVie * (pourcent / 100));

            if (pdv > joueur.PointDeVieMax)
                pdv = joueur.PointDeVieMax;

            joueur.PointDeVie = (int)Math.Round(pdv);
        }
    }
}
