using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace El_Chapo
{
    /// Classe globale pour avoir accès à ces fonctions qui sont utilisées seulement pour le choix utilisateur.
    /// <Launcher>
    /// Permet d'avoir accès à ma liste de catcheurs dès l'instant où je lance le programme.
    /// </Launcher>
    class Launcher
    {
        ListCatcheurs _catcheurs;

        public Launcher()
        {
            _catcheurs = new ListCatcheurs();
        }

        /// <Start>
        /// Fonction principale du programme. Elle permet l'affichage du menu principal ainsi que l'appel de la fonction GetUserChoice()
        /// qui permet une première interaction avec les utilisateurs.
        /// </Start>
        public void Start()
        {
            Menus Principal_menu = new Menus();
            Menus.DisplayWelcome();
            Menus.ChoiceMainMenu();

            GetUserChoice(_catcheurs);
        }

        /// <GetUserChoice>
        /// Fonction qui récupère seulement le choix utilisateur avec gestion d'erreur au cas où il ne selectionne pas un nombre ou pas le bon.
        /// </GetUserChoice>
        public int GetUserChoice(ListCatcheurs maList)
        {
            string choix_user;
            int nbr_choix_user;

            // Test de l'entrée utilisateur : Si c'est pas bon je rappel la fonction et je raffiche le menu en lui disant qu'il s'est trompé... 
            choix_user = Console.ReadLine();
            bool parsed = int.TryParse(choix_user, out nbr_choix_user);
            if (!parsed)
            {
                Console.WriteLine("Veuillez rentrer un nombre correspondant au menu s'il vous plaît !\n");
                Start();
                return (0);
            }
            //Sinon on applique le choix utilisateur au switch grâce à la fonction 'The_choice'
            else
                TheChoice(nbr_choix_user);
            return (nbr_choix_user);
        }


        /// <TheChoice>
        /// Fonction qui applique le choix de l'utilisateur sur notre menu et qui le redirige selon son choix. Prend en paramètre un entier correspondant au choix utilisateur,
        /// ainsi que la liste des catcheurs.
        /// <param name="nbr_choixUser"></param>
        /// </TheChoice>
        public void TheChoice(int nbr_choixUser)
        {
            switch (nbr_choixUser)
            {
                case 1:
                    Console.WriteLine("Vous avez selectionné : Créer un match !");
                    /*Combat combat = new Combat(_catcheurs);//Pour toi guillian : 
                    ReturnMenu();*/
                    return;
                case 2:
                    Console.WriteLine("Vous avez selectionné : Consulter l'historique des matchs!");
                    ReturnMenu();
                    break;
                case 3:
                    Console.WriteLine("Vous avez selectionné : Consulter la base des contacts! \n");
                    _catcheurs.DisplayListOfCatcheur();
                    ReturnMenu();
                    break;
                case 4:
                    Console.WriteLine("Vous avez selectionné : Quitter le jeu!");
                    Confirmation();
                    break;
                default:
                    Console.WriteLine(" Veuillez rentrer le bon nombre ! \n");
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    Start();
                    break;
            }
        }

        /// <ReturnMenu>
        /// Fonction qui retourne au menu 
        /// </ReturnMenu>
        public void ReturnMenu()
        {
            string ok;
            Console.WriteLine("Veuillez tapez 'Q' ou 'quit' pour retourner au menu : ");
            ok = Console.ReadLine();

            if (ok == "Q" || ok == "q" || ok == "quit")
            {
                Start();
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Veuillez choisir une des propositions en respectant la syntaxe 'Q', 'q' ou 'quit' pour retourner au menu.");
                ReturnMenu();
                return;
            }
        }

        /// <Confirmation>
        /// Fonction qui demande à l'utilisateur s'il veut réélement quitter l'appli.
        /// </Confirmation>
        public void Confirmation()
        {
            string ok;
            Console.WriteLine("Voulez vous vraiment quitter l'application ?\n");
            Console.WriteLine("Tapez 'Y' pour quitter définitivement, 'N' pour retourner au menu\n");
            ok = Console.ReadLine();

            if (ok == "Y" || ok == "y")
            {
                Menus.DisplayGoodBye();
                Console.WriteLine("Appuyez sur n'importe quelle touche pour quitter.");
                Console.Read();
            }
            else if (ok == "N" || ok == "n")
            {
                Console.WriteLine("Vous avez choisi 'Non'. Retour au menu.\n");
                Start();
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
