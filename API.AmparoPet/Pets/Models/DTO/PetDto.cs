using System.ComponentModel.DataAnnotations;

namespace API.AmparoPet.Pets.Models.DTO
{
    public class PetDto
    {
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }

        //public Carer Carer { get; set; }
        //public int? CardVaccineID { get; set; }
        //public CardVaccine CardVaccine { get; set; }
    }
}
