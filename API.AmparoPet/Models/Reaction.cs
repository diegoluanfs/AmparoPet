using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.AmparoPet.Models
{
    public class Reaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int ReactionID { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        public int? PostId { get; set; }
        public Post Post { get; set; }

    }
}
