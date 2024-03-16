using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace API.AmparoPet.Models
{
    public class Address
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int AddressID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public Carer Carer { get; set; }
        public int? PostId { get; set; }
        public Post Post { get; set; }
    }
}
