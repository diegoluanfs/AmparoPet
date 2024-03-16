using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace API.AmparoPet.Models
{
    public class Document
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int DocumentID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public Carer Carer { get; set; }
    }
}
