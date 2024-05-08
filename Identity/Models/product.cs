using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class product
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int price { get; set; }


    }
}
