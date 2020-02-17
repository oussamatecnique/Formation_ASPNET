using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pam_metier_simule.metier.entites
{
    public class Indemnites
    {
        public int Indice { get; set; }
        public double BaseHeure { get; set; }
        public double EntretienJour { get; set; }
        public double RepasJour { get; set; }
        public double IndemnitesCp { get; set; }
        // to string
        public override string ToString()
        {
            return string.Format("Indemnités[{0},{1},{2},{3},{4}]", Indice, BaseHeure,
            EntretienJour, RepasJour, IndemnitesCp);
        }
    }
}

