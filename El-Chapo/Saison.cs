using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Chapo
{
    /// <Saison>
    /// Permet de créer une nouvelle saison et d'incrémenter les semaines et les saisons.
    /// </Saison>
    public class Saison
    {
        public int saisonCompteur { get; set; }
        public int semaineCompteur { get; set; }

        public void NewSaison()
        {
            saisonCompteur = 1;

            if (semaineCompteur == 8)
            {
                saisonCompteur += 1;
                Console.WriteLine("Semaine 8 atteinte félicitation ! Une nouvelle saison commence ! Vous etes donc en saison " + saisonCompteur);
                semaineCompteur = 1;
            }
        }
    }
}
