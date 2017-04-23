using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Chapo
{
    class CreationCombat 
    {
        private static object nbr_choix_usr;

        public static int GetUserChoiceCatcheur(ListCatcheurs maList)
        {
            string choix_user;
            int nbr_choix_user;

            //Affichage de la liste de catcheur
            maList.DisplayListOfCatcheur(1);

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
                CreationCombat.TheChoiceOfCatcheur(nbr_choix_usr);
            return (nbr_choix_user);
        }

        private static void TheChoiceOfCatcheur(object nbr_choix_usr)
        {
            throw new NotImplementedException();
        }

        public void  TheChoiceOfCatcheur(int nbr_choixUser, ListCatcheurs maListe)
        {
            
            maListe.DisplayListOfCatcheur(nbr_choixUser);
            int index = Combat.catcheur;
             Combat.catcheur1 = maListe.TheListOfCatcheur[index];
            GetUserChoiceCatcheur(nbr_choixUser);
            int index2 = Combat.catcheur;
            Combat.catcheur2 = maListe.TheListOfCatcheur[index];

        }

        private void GetUserChoiceCatcheur(int nbr_choixUser)
        {
            throw new NotImplementedException();
        }

        internal static void GetUserChoiceCatcheur()
        {
            throw new NotImplementedException();
        }
    }
}
