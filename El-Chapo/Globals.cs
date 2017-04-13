using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace El_Chapo
{
    // Classe globale pour avoir accès à ces fonctions qui sont utilisées seulement pour le choix utilisateur.
    class Globals
    {

        // Fonction qui récupère seulement le choix utilisateur avec gestion d'erreur au cas où il ne selectionne pas un nombre ou pas le bon.
        public static int GetUserChoice()
        {
            string choix_user;
            int nbr_choix_user;

            Menus Principal_menu = new Menus();
            Menus.DisplayWelcome();
            Menus.ChoiceMainMenu();

            choix_user = Console.ReadLine();
            bool parsed = int.TryParse(choix_user, out nbr_choix_user);
            if (!parsed)
            {
                Console.WriteLine("Veuillez rentrer un nombre correspondant au menu s'il vous plaît !\n");
                GetUserChoice();
                return(0);
            }
            else
            {
                The_choice(nbr_choix_user);
            }
            return (nbr_choix_user);
        }

        public static void The_choice(int nbr_choixUser)
        {
            switch (nbr_choixUser)
            {
                case 1:
                    Console.WriteLine("Vous avez selectionné : Créer un match !");
                    //Thread.Sleep(TimeSpan.FromSeconds(1));
                    return;
                case 2:
                    Console.WriteLine("Vous avez selectionné : Consulter l'historique des matchs!");
                    break;
                case 3:
                    Console.WriteLine("Vous avez selectionné : Consulter la base des contacts!");
                    break;
                case 4:
                    Console.WriteLine("Vous avez selectionné : Quitter le jeu!");
                    Confirmation();
                    break;
                default:
                    Console.WriteLine(" Veuillez rentrer le bon nombre ! \n");
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    //first_menu();
                    break;
            }
        }

        public static void Confirmation()
        {
            string ok;
            Console.WriteLine("Voulez vous vraiment quitter l'application ?\n");
            Console.WriteLine("Tapez 'Y' pour confirmer, 'N' pour rester\n");
            ok = Console.ReadLine();

            if (ok == "Y")
            {
                Menus.DisplayGoodBye();
                Console.WriteLine("Appuyez sur n'importe quelle touche pour quitter.");
                Console.Read();
            }
            else if (ok == "N")
            {
                Console.WriteLine("Vous avez cliqué sur 'Non'. Retour au menu.\n");
                GetUserChoice();
            }
            else
            {
                Console.WriteLine("Veuillez choisir une des propositions en respectant la syntaxe 'Y' pour quitter, 'N' pour retourner au menu.");
                Confirmation();
                return;
            }
        }
    }
}
