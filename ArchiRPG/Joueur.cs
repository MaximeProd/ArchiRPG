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

        public void Attaquer(ICombattant combattant)
        {
            Console.WriteLine("Appuyer sur entrée pour lancer les dés");
            Console.ReadLine();
            var randomCustom = new RandomLibrary();
            var resultDes = randomCustom.getDesDouze();
            var ptsDegat = resultDes + combattant.Force - combattant.Armure;
            var resultAttaque = ptsDegat - combattant.PointDeVie;
            combattant.PointDeVie -= ptsDegat;
        }

        public void afficherStats()
        {
            Console.WriteLine("Voilà vos stats actuelles :" +
                "\n\t Niveau : " + this.Niveau +
                "\n\t Force : " + this.Force +
                "\n\t Armure : " + this.Armure +
                "\n\t Points de vie  : " + this.PointDeVie
        );
        }

		public bool IsAlive()
		{
      return PointDeVie > 0;
		}
	}
}
