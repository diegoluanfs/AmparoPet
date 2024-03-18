using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace API.AmparoPet.Models
{
    public class CardVaccine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public int CardVaccineID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public ICollection<Vaccine> Vaccines { get; set; }
    }
}
