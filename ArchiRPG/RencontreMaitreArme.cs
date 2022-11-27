using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArchiRPG.Interface;

namespace ArchiRPG
{
	internal class RencontreMaitreArme : IRencontre
	{
		public Joueur Joueur { get; set; }

		public void LancerRencontre(Joueur joueur)
		{
			throw new NotImplementedException();
		}

		public void Insulter(){
			throw new NotImplementedException();
		}
	}
}
