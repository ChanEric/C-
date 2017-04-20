using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Chapo
{
    public class ListCatcheurs
    {
        public void ListOfCatcheur()
        {
            List<Catcheur> TheListOfCatcheur = new List<Catcheur>();
            TheListOfCatcheur.Add(new Catcheur());
        }
    }

    class JudySunny : Brute
    {
        String name = "Judy Sunny";

        String SpeCompentence = "40% de chance de regagner 5 points de vie (ne peux depasser la vie max), 60% de chance de parer 1 point de dégât supplémentaire.";
        String Statut = "Operationnel";

        public override void Competence()
        {
            Random pourcentageDeChance1 = new Random();
            int rndPourcentage = pourcentageDeChance1.Next();

            if (rndPourcentage <= 3)
            {
                int augmentationPointDeVie = 5;
                int i = 0;

                while (i <= pointDeVie)
                {
                    if (i == 100)
                    {
                        Console.WriteLine("Points de vie au mximum")
                    }
                }
                Console.WriteLine("Points de vie au maximum");
                return;
                else
                {
                    pointDeVie = pointDeVie + 5;
                }
            }
            else
            {
                Console.WriteLine("Capacité échouée !");
                return;
            }

            Random pourcentageDeChance2 = new Random();
            int rndPourcentage2 = pourcentageDeChance2.Next();

            if (rndPourcentage2 <= 5)
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
        String Statut = "Operationnel";


        public override void Competence()
        {

        }
    }
    class Deadpoule : Agile
    {
        String SpeCompentence = "10% de chance de subtiliser 3 pvs de l’ennemie en plus de l’attaque, 30% de chances de se soigner de 2 pvs et 10% de chances de parer 1 dégat";
        String Statut = "Operationnel";


        public override void Competence()
        {

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
        String Statut = "Operationnel";


        public override void Competence()
        {

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
        String Statut = "Operationnel";


        public override void Competence()
        {

        }
    }
    class ChrisHart : Brute
    {
        String SpeCompentence = "30% de chance d’annuler une attaque";
        String Statut = "Operationnel";


        public override void Competence()
        {

        }
    }
    class BretBenoit : Agile
    {
        String SpeCompentence = "8% de chance de mettre instantanément K.O l’adversaire";
        String Statut = "Operationnel";


        public override void Competence()
        {

        }
    }

}
