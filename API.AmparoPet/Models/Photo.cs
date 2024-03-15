using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace API.AmparoPet.Models
{
    public class Photo
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int PhotoID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
