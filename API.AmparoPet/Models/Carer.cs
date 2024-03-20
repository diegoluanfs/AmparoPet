using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace API.AmparoPet.Models
{
    public class Carer
    {
        public int CarerID { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [StringLength(50)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated At")]
        public DateTime UpdatedAt { get; set; }

        public int? AddressID { get; set; }
        public Address Address { get; set; }
        public ICollection<Pet> Pets { get; set; }

        //    public Document? Document { get; set; }
        //    public ICollection<Photo>? Photos { get; set; }

        public ICollection<Post> Posts { get; set; }
        //    public ICollection<Comment>? Comments { get; set; }
    }
}
