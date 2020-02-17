using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vue_ET_Son_Model.Models
{
    public class ActionModel06
    {
        [Required(ErrorMessage = "Le paramètre [personneId] est requis")]
        public int PersonneId { get; set; }
        [Required(ErrorMessage = "Le paramètre [valider] est requis")]
        public string Valider { get; set; }
    }
}