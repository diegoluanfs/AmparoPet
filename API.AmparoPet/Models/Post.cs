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

        public ICollection<Pet> Pets { get; set; }

        //public ICollection<Carer> Caregivers { get; set; }

        public ICollection<Photo> Photos { get; set; }

        [Display(Name = "Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        public int CarerId { get; set; }
        public Carer Carer { get; set; }
    }
}
