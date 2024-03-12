using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace API.AmparoPet.Models
{
    public class Pet
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int PetID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public ICollection<Carer> Caregivers { get; set; }
    }
}
