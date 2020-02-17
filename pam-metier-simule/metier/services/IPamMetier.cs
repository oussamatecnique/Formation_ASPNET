using pam_metier_simule.metier.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pam_metier_simule.metier.services
{
    public interface IPamMetier
    {
        Employe[] GetAllIdentitesEmployes();
        FeuilleSalaire GetSalaire(string ss, double heuresTravaillées, int joursTravaillés);

    }
}
