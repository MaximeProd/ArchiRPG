using ArchiRPG.Helper;
using ArchiRPG.Interface;

namespace ArchiRPG
{
    internal class Joueur : ICombattant
    {
        public int Armure { get; set; }
        public int PointDeVie { get; set; }
        public int Force { get; set; }

        public int Niveau { get; set; }
        public int PointDeVieMax { get; set; }

        public Joueur()
        {
            Niveau = 1;
            Force = 15;
            Armure = 15;
            PointDeVie = 20;
            PointDeVieMax = 30;
        }

        public void Attaquer(ICombattant defenseur)
        {
            Console.WriteLine("Appuyer sur entrée pour lancer les dés");
            Console.ReadLine();
            var randomCustom = new RandomLibrary();
            var resultDes = randomCustom.getDesDouze();
            var ptsDegat = resultDes + Force - defenseur.Armure;
            defenseur.PointDeVie -= ptsDegat;
        }

        public void afficherStats()
        {
            Console.WriteLine("Voilà vos stats actuelles :" +
                "\n\t Niveau : " + this.Niveau +
                "\n\t Force : " + this.Force +
                "\n\t Armure : " + this.Armure +
                "\n\t Points de vie  : " + (IsAlive() ? this.PointDeVie : 0)
        );
        }

        public bool IsAlive()
        {
            return PointDeVie > 0;
        }
    }
}
