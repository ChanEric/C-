using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Chapo
{
    public class ListCatcheurs
    {
        public List<Catcheur> TheListOfCatcheur;

        public ListCatcheurs()
        {
            TheListOfCatcheur = new List<Catcheur>
            {
                new Brute("L'ordonnateur des pompes funèbres", StatutCatcheur.Disponible),
                new Agile("Triple hache", StatutCatcheur.Disponible),
                new Agile("Dead poule", StatutCatcheur.Disponible),
                new Brute("Judy Sunny", StatutCatcheur.Disponible),
                new Brute("Jarvan cinquième du nom", StatutCatcheur.Convalescence),
                new Agile("Madusa", StatutCatcheur.Disponible),
                new Agile("John Cinéma", StatutCatcheur.Convalescence),
                new Brute("Jeff Radis", StatutCatcheur.Convalescence),
                new Brute("Raie Mystérieuse", StatutCatcheur.Disponible),
                new Brute("Chris Hart", StatutCatcheur.Disponible),
                new Agile("John Cinéma", StatutCatcheur.Convalescence),
            };
        }

        public void DisplayListOfCatcheur()
        {
            foreach (Catcheur i in TheListOfCatcheur)
            {
                Console.WriteLine("Nom du catcheur : " + i.name);  
                Console.WriteLine("PV = " + i.pointDeVie);
                Console.WriteLine("points d'attaque = " + i.attaque);
                Console.WriteLine("points de defence = " + i.defense);
                Console.WriteLine("\n");
            }
        }
    }
}
/*    class JudySunny : Brute
    {
        String name = "Judy Sunny";

        String SpeCompentence = "40% de chance de regagner 5 points de vie (ne peux depasser la vie max), 60% de chance de parer 1 point de dégât supplémentaire.";
        String Statut = "Disponible";

        public override void Competence()
        {
            Random pourcentageDeChance1 = new Random();
            int rndPourcentage = pourcentageDeChance1.Next(0, 9);

            if (rndPourcentage <= 3)
            {
                int augmentationPointDeVie = 5;
                int i = 0;

                while (i <= augmentationPointDeVie)
                {
                    if ((i + pointDeVie) == 100)
                    {
                        pointDeVie = pointDeVie + i;
                        Console.WriteLine("Points de vie au mximum");
                    }
                    else if (i == augmentationPointDeVie)
                    {
                        Console.WriteLine("Capacité spéciale éffectuée ! +5 points de vie à votre personnage !");
                    }
                    else
                        i++;
                }
            }
            else
            {
                Console.WriteLine("Capacité échouée !");
                return;
            }

            rndPourcentage = pourcentageDeChance1.Next(0, 9);
            if (rndPourcentage <= 5)
            {
                // Ont doit parer 1 dégât
            }
            else
            {
                Console.WriteLine("Capacité échouée !");
                return;
            }
        }
    }

    class Triplehache : Agile
    {
        String SpeCompentence = "20% de chance d’infliger 2 dégâts supplémentaires mais perd alors 1 point de vie";
        String Statut = "Disponible";


        public override void Competence()
        {

        }
    }

    class Deadpoule : Agile
    {
        String SpeCompentence = "10% de chance de subtiliser 3 pvs de l’ennemie en plus de l’attaque, 30% de chances de se soigner de 2 pvs et 10% de chances de parer 1 dégat";
        String Statut = "Disponible";


        public override void Competence()
        {
            Random pourcentageDeChance1 = new Random();
            int rndPourcentage = pourcentageDeChance1.Next(0, 9);

            if (rndPourcentage == 0)
            {
                Console.WriteLine("Capacité spéciale éffectuée ! Subtilisation de 3pvs en plus sur votre attaque !");
                attaque = attaque + 3;
            }
            else
            {
                Console.WriteLine("Capacité échouée !");
                return;
            }

            rndPourcentage = pourcentageDeChance1.Next(0, 9);
            if (rndPourcentage <= 2)
            {
                Console.WriteLine("Capacité spéciale éffectuée ! Vous vous êtes soignés de 2pvs !");
                pointDeVie = pointDeVie + 2;
            }
            else
            {
                Console.WriteLine("Capacité échouée !");
                return;
            }

            rndPourcentage = pourcentageDeChance1.Next(0, 9);
            if (rndPourcentage == 0)
            {
                Console.WriteLine("Capacité spéciale éffectuée ! Vous parez 1 dégât en plus !");
                //parer un dégat !
            }
            else
            {
                Console.WriteLine("Capacité échouée !");
                return;
            }
        }
    }
    class Jarvan5DuNom : Brute
    {
        String SpeCompentence = "30% de chance d’annuler une attaque";
        String Statut = "En convalescence";


        public override void Competence()
        {

        }
    }
    class Madusa : Agile
    {
        String SpeCompentence = "40% de chance de se protéger contre 4 points de dégâts, mais n’en inflige qu’un seul durant le tour.";
        String Statut = "Disponible";


        public override void Competence()
        {
            Random pourcentageDeChance1 = new Random();
            int rndPourcentage = pourcentageDeChance1.Next(0, 9);

            if (rndPourcentage <= 3)
            {

            }
            else
            {
                Console.WriteLine("Capacité échouée !");
                return;
            }
        }
    }
    class JohnCinema : Agile
    {
        String SpeCompentence = "20% de chance d’infliger 2 dégâts supplémentaires mais perd alors 1 point de vie.";
        String Statut = "En convalescence";


        public override void Competence()
        {

        }
    }
    class JeffRadis : Brute
    {
        String SpeCompentence = "30% de chance d’annuler une attaque.";
        String Statut = "En convalescence";


        public override void Competence()
        {

        }
    }
    class RaieMysterieuse : Brute
    {
        String SpeCompentence = "40% de chance de s’infliger 3 dégâts, sinon inflige 1 dégât supplémentaire et se protège de 2 dégâts infligés";
        String Statut = "Disponible";


        public override void Competence()
        {

        }
    }
    class ChrisHart : Brute
    {
        String SpeCompentence = "30% de chance d’annuler une attaque";
        String Statut = "Disponible";


        public override void Competence()
        {

        }
    }
    class BretBenoit : Agile
    {
        String SpeCompentence = "8% de chance de mettre instantanément K.O l’adversaire";
        String Statut = "Disponible";


        public override void Competence()
        {

        }
    }

}
*/