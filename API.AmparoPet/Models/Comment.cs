using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.AmparoPet.Models
{
    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CommentID { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

    }
}
