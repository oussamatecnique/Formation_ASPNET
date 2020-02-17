using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pam_metier_simule.metier.entites
{
    public class Cotisations
    {
        public double CsgRds { get; set; }
        public double Csgd { get; set; }
        public double Secu { get; set; }
        public double Retraite { get; set; }
        // signature
        public override string ToString()
        {
            return string.Format("Cotisations[{0},{1},{2},{3}]", CsgRds, Csgd, Secu, Retraite);
        }
    }
}
