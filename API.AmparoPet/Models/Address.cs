using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.AmparoPet.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public int AddressID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Cep { get; set; }

        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }

        // Tornando Carer opcional (nullable)
        //public Carer? Carer { get; set; }

        //public Post? Post { get; set; }
    }
}
