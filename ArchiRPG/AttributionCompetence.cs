namespace ArchiRPG
{
	internal class AttributionCompetence
	{
		public Joueur AttribuerCompetence(Joueur joueur, int nbPointAttribuer){
			var resteNbPointAttribuer = nbPointAttribuer;
			do
			{
				
				var competence = 0;
				Console.WriteLine("\nIl vous reste " + resteNbPointAttribuer + " points à attribuer");
                do
                {
                    Console.WriteLine("Quelle compétence voulez-vous améliorer ? " +
                                        "\n\t 1 - Force" +
                                        "\n\t 2 - Armure" +
                                        "\n\t 3 - Point de vie");
					try
					{
                        competence = int.Parse(Console.ReadLine());
                    } catch(Exception e)
					{
						Console.WriteLine("Veuillez entrer un nombre valide");
					}
                } while (competence != 1 && competence != 2 && competence != 3);

                var nouvelleVal = 0;
				do
				{
					Console.WriteLine("Veuillez entrer le nombre de points à attribuer");
					try
					{
                        nouvelleVal = int.Parse(Console.ReadLine());
                    }
					catch (Exception e)
					{
                        Console.WriteLine("Veuillez entrer un nombre valide");
                    }
                } while (nouvelleVal > nbPointAttribuer);

				switch (competence)
				{
					case (int)ECompetence.Force:
						joueur.Force += nouvelleVal;
						resteNbPointAttribuer -= nouvelleVal;
						break;
					case (int)ECompetence.Armure:
						joueur.Armure += nouvelleVal;
						resteNbPointAttribuer -= nouvelleVal;
						break;
					case (int)ECompetence.PointDeVie:
						joueur.PointDeVie += nouvelleVal;
						resteNbPointAttribuer -= nouvelleVal;
						break;
				}

			} while (resteNbPointAttribuer > 0);
			return joueur;
		}
	}
}
