using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Chapo
{
    class Brute : Catcheur
    {

        public override void Competence()   {

            attaque = 5;
            defense = 1;
            pointDeVie = 125;
            Console.WriteLine("Vie{0}, def{1} atq{2}", pointDeVie, defense, attaque);
        

        }



    }
}
