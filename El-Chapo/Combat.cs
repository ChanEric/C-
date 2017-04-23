using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Chapo
{
    class Combat : Catcheur
    {
        //rappel de la fonction theChoiceOfCatcheur()
        public static int catcheur1 { get; set; }
        public static int catcheur2 { get; set; }
        public static int catcheur { get; set; }
        public static string Name { get; private set; }
        public static int pdv { get; private set; }
        public static int Att { get; private set; }
        public static int def { get; private set; }

        public static int vieEnMoins;
        private static int i;
        public ListCatcheurs _catcheurs;

        public Combat(string Name, int pdv, int att, int def) : base(Name, pdv, att, def)
        {
        }

        public Combat(ListCatcheurs _catcheurs) : base(Name, pdv, Att, def)
        {
            this._catcheurs = _catcheurs;
        }

        public static void  SystemCombat(ListCatcheurs maList)
        {
            for(i =0; i < 20; i++)
            {
                Combat.FirstPlayers(Combat.catcheur1);
                Mouvment();
                maList.DisplayListOfCatcheur(Combat.catcheur1);
                maList.DisplayListOfCatcheur(Combat.catcheur2);

            }
        }
        

        public static int FirstPlayers( int catheur1)
        {
            
            Random o_random = new Random();

            bool attaque = Convert.ToBoolean(o_random.Next() % 2);

            catheur1 = Convert.ToInt16( attaque);

            return catheur1;
        }

        public static int Attack(int vieEnMoins, int catcheur1, int catcheur2, ListCatcheurs maListe)
        {
            if (catcheur1 == 1)
            {
                int index = Combat.catcheur2;
                if (vieEnMoins == 0)
                {

                    Combat.catcheur2 = maListe.TheListOfCatcheur[index] = pointDeVie -= 5;

                }
                else Combat.catcheur1 = maListe.TheListOfCatcheur[index] = pointDeVie -= vieEnMoins;
            } else if (catcheur2 == 1)
            {
                int index = Combat.catcheur1;
                if (vieEnMoins == 0)
                {

                    
                    Combat.catcheur1 = maListe.TheListOfCatcheur[index] = pointDeVie -=5;

                }
                else Combat.catcheur1 = maListe.TheListOfCatcheur[index] =  pointDeVie -= vieEnMoins;
            }

                return pointDeVie;
        }

        internal static void SystemCombat(Combat combat)
        {
            throw new NotImplementedException();
        }

        public static int Shield(int catcheur1, int catcheur2, ListCatcheurs maListe)
        {
            int index = Combat.catcheur;
            Combat.catcheur1 = maListe.TheListOfCatcheur[index] = pointDeVie += 5;

            return vieEnMoins;

        }

        public  static void Mouvment()
        {
            Random num1 = new Random();
            num1.Next(2);
            int choix1 = Convert.ToInt16(num1);

            Random num2 = new Random();
            num2.Next(2);
            int choix2 = Convert.ToInt16(num2);

            if (choix1 == 2 || choix2 == 2)
            {
                Combat.Shield(Combat.catcheur1, Combat.catcheur2);
            }
            else Combat.Attack(0, Combat.catcheur1, Combat.catcheur2);


        }

        private static void Attack(int v, int catcheur1, int catcheur2)
        {
            throw new NotImplementedException();
        }

        private static void Shield(int catcheur1, int catcheur2)
        {
            throw new NotImplementedException();
        }
    }   




}
