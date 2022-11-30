namespace ArchiRPG.Helper
{
    public class RandomLibrary
    {

        public int GetPourcentage(int pourcentageMin, int pourcentageMax)
        {
            var random = new Random();
            // on rajoute + 1 car c'est un strictement inférieur à..
            return random.Next(pourcentageMin, pourcentageMax + 1);
        }

        public int GetDesDouze()
        {
            var random = new Random();
            return random.Next(1, 13);
        }

    }
}
