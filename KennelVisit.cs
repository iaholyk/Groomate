using System;
using System.ComponentModel.DataAnnotations;

namespace IdentitySample.Models
{
    public class KennelVisit
    {
        [Key]
        [Required]
        public int KennelVisitId { get; set; }

        [Display(Name = "Check In")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime ChekInDate { get; set; }
        [Display(Name = "Check Out Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime ChekOutDate { get; set; }
        [Display(Name = "Checked Out")]
     
        public bool CheckedOut { get; set; }
        public Pets Pets { get; set; }
    }
}