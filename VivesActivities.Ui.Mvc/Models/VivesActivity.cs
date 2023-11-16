using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VivesActivities.Ui.Mvc.Models
{
    [Table(nameof(VivesActivity))]
    public class VivesActivity
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }
        public string? Description { get; set; }

        [Display(Name= "Activity type")]
        public string? Type { get; set; }

        [Required]
        public required string Location { get; set; }
    }
}
