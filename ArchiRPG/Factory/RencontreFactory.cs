using ArchiRPG.Helper;
using ArchiRPG.Interface;

namespace ArchiRPG.Factory
{
    internal class RencontreFactory
    {

        public IRencontre CreerRencontre()
        {
            var randomCustom = new RandomLibrary();
            var randomRencontre = randomCustom.getPourcentage(1, 100);

            if (randomRencontre <= 25)
                return new RencontreMerlin();
            else if (randomRencontre > 25 && randomRencontre < 50)
                return new RencontreMaitreArme();
            else
                return new RencontreMob();
        }
    }
}
