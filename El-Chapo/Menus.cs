using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Chapo
{
    class Menus
    {
        public static void DisplayWelcome()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("Bienvenue dans l'application El Chapo !");

        }

        public static void DisplayGoodBye()
        {
            Console.WriteLine("Merci d'avoir utilisé l'application !");
            Console.WriteLine("A bientôt");
        }

        public static void ChoiceMainMenu()
        {
            Console.WriteLine("**** Menu principal ****");
            Console.WriteLine("1. Créer le match de Samedi");
            Console.WriteLine("2. Consulter l'historique des matchs");
            Console.WriteLine("3. Consulter la base des contacts");
            Console.WriteLine("4. Quitter le jeu");
        }
    }
}

