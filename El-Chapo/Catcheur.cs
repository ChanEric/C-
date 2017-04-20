using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Chapo
{
    class Catcheur
    {

        public int pointDeVie;
        public int attaque;
        public int defense;

        public int ComSpePointDeVie;
        public int ComSpeAttaque;
        public int ComSpeDefense;


        public virtual void Competence()
        {
            pointDeVie = 0;
            attaque = 0;
            defense = 0;
        }
    }
}
