using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Chapo
{
    public enum StatutCatcheur
    {
        Disponible,
        Convalescence,
        HorsEtat,
    }

    public class Catcheur
    {
        public String name { get; set; }
        public int pointDeVie { get; set; }
        public int attaque { get; set; }
        public int defense { get; set; }

        public Catcheur(string Name, int pdv, int att, int def)
        {
            name = Name;
            pointDeVie = pdv;
            attaque = att;
            defense = def;
        }
    }
}
