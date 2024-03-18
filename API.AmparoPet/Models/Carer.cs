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
        public string FirstMidName { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Hire Date")]
        //public DateTime HireDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }

        public int? AddressID { get; set; }
        public Address Address { get; set; }
        public ICollection<Pet> Pets { get; set; }

        //    public Document? Document { get; set; }
        //    public ICollection<Photo>? Photos { get; set; }

        //    public ICollection<Post>? Posts { get; set; }
        //    public ICollection<Comment>? Comments { get; set; }
    }
}
