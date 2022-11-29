using ArchiRPG.Helper;
using ArchiRPG.Interface;

namespace ArchiRPG.Factory
{
    internal class RencontreFactory
    {

        public IRencontre CreerRencontre()
        {
            var randomCustom = new RandomLibrary();
            var randomRencontre = randomCustom.getPourcentage(100);

            if (randomRencontre <= 25)
                return new RencontreMerlin();
            else if (randomRencontre > 25 && randomRencontre < 50)
                return new RencontreMaitreArme();
            else
                return new RencontreMob();


            /*// TODO : Instancier une rencontre
            var selected = RandomLibrary.getPourcentages(
              (typeof(RencontreMaitreArme), 25),
              (typeof(RencontreMerlin), 25),
              (typeof(RencontreMob), 50)
            );

            return (IRencontre)Activator.CreateInstance(selected.GetType(), new object[] { });*/
        }
    }
}
