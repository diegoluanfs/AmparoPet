using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.AmparoPet.Models
{
    public class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int PostID { get; set; }

        [Required]
        [Display(Name = "Title")]
        [StringLength(50)]
        public string Title { get; set; }

        public Address Address { get; set; }

    }
}
