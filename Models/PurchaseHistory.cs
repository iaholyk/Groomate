using System;
using System.ComponentModel.DataAnnotations;

namespace IdentitySample.Models
{
    public class PurchaseHistory
    {
        [Key]
        [Required]
        public int PurchaseId { get; set; }

        [Display(Name = "Purchase Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }

        [Display(Name = "Package")]
        [Required]
        [DataType(DataType.Text)]
        public string Package { get; set; }

        [Display(Name = "Dog Name")]
        [Required]
        [DataType(DataType.Text)]
        public string Dog { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}