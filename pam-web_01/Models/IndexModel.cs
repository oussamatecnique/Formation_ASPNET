using Action_Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pam_web_01.Models
{
    [Bind(Exclude = "Application")]
    public class IndexModel
    {
        // données de portée application
        public ApplicationModel Application { get; set; }
        // valeurs postées
        [Required]
        [Display(Name = "Employé")]
        public string SS { get; set; }
        [Required]
        [Display(Name = "Heures travaillées")]
        [UIHint("Decimal")]
        [Range(0,400,ErrorMessage ="entrer un nombre entre 0 et 400")]
        public double HeuresTravaillées { get; set; }
        [Required]
        [Display(Name = "Jours travaillés")]
        [Range(0,31, ErrorMessage = "entrer un nombre entre 0 et 31")]
        public double JoursTravaillés { get; set; }
    }
}