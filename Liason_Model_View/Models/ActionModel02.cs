using System.ComponentModel.DataAnnotations;

namespace Action_Model.Models
{
    public class ActionModel02
    {
        [Required]
        [Range(1, 200)]
        public double? Poids { get; set; }
        [Required]
        [Range(1, 150)]
        public int? Age { get; set; }
    }
}