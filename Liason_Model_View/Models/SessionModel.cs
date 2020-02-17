using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Action_Model.Models
{
    public class SessionModel
    {
        public int Compteur { get; set; }
        public SessionModel()
        {
            Compteur = 0;
        }
    }
}