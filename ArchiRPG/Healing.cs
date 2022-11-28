using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiRPG
{
	internal class Healing
	{
	    public int RestorePv(Joueur joueur, int pourcent) {
		var pdv = joueur.PointDeVie + (joueur.PointDeVie * (pourcent / 100));
		    
		if(pdv > joueur.PointDeVieMax)
		    pdv = joueur.PointDeVieMax;
		    
	        joueur.PointDeVie = Math.Round(pdv);
		return joueur.PointDeVie;
	    }
	}
}
