using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Chapo
{
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
