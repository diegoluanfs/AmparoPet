using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.AmparoPet.Models
{
    public class Vaccine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Vaccine ID")]
        public int VaccineId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        public DateTime AdministeredDate { get; set; }

        //[Display(Name = "Card Vaccine ID")]
        //public int CardVaccineId { get; set; }
        
        //public CardVaccine CardVaccine { get; set; }
    }
}
