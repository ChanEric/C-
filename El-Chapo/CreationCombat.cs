using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Chapo
{
    class CreationCombat
    {
        public static int GetUserChoiceCatcheur(ListCatcheurs maList)
        {
            string choix_user;
            int nbr_choix_user;

            //Affichage de la liste de catcheur
            maList.DisplayListOfCatcheur();

            // Test de l'entrée utilisateur : Si c'est pas bon je rappel la fonction et je raffiche le menu en lui disant qu'il s'est trompé... 
            choix_user = Console.ReadLine();
            bool parsed = int.TryParse(choix_user, out nbr_choix_user);
            if (!parsed)
            {
                Console.WriteLine("Veuillez rentrer un nombre correspondant au menu s'il vous plaît !\n");
                GetUserChoiceCatcheur(maList);
                return (0);
            }
            //Sinon on applique le choix utilisateur au switch grâce à la fonction 'The_choice'
            else
                TheChoiceOfCatcheur(nbr_choix_user);
            return (nbr_choix_user);
        }

        public static void TheChoiceOfCatcheur(int nbr_choixUser)
        {
            //Pour toi guillian tu traite une première fois le nrb_choixUser qui contient le numéro du catcheur 
            // Tu extrait le catcheur voulu.
            // Tu rappel GetUserChoiceCatcheur
            // tu retraite une deuxieme fois le nbr_choixUser pour selectionner le deuxieme catcheur de la liste.
        }
    }
}
