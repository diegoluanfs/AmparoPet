using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace API.AmparoPet.Models
{
    public class Pet
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public int PetID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public int? CarerID { get; set; }
        public Carer Carer { get; set; }
        public int? CardVaccineID { get; set; }
        public CardVaccine CardVaccine { get; set; }
        //public CardVaccine CardVaccine { get; set; }
        //public ICollection<Photo> Photos { get; set; }
        //public int? PostId { get; set; }
        //public Post Post { get; set; }
    }
}
