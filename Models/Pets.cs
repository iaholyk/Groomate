using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentitySample.Models
{
    public class Pets
    {
        [Key]
        [Required]
        public int PetId { get; set; }

        [Required]
        [Display(Name = "Pet Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Display(Name = "Pet Picture")]
        public byte[] Image { get; set; }

        [Display(Name = "Pet AKA")]
        [DataType(DataType.Text)]
        public string Nickname { get; set; }

        [Display(Name = "Owner Full Name")]
        [Required]
        [DataType(DataType.Text)]
        public string OwnerName { get; set; }

        [Display(Name = "Dog Weight(Best Guess)")]
        [Required]
        [DataType(DataType.Text)]
        public decimal Weight { get; set; }

        [Display(Name = "Dog Age(Human Years)")]
        [Required]
        [DataType(DataType.Text)]
        public int Age { get; set; }

        [Display(Name = "Allergies")]
      
        [DataType(DataType.MultilineText)]
        public string Allergies { get; set; }

        [Display(Name = "Dog Breed")]
        [Required]
        [DataType(DataType.Text)]
        public string Breed { get; set; }

        [Display(Name = "Muzzle?")]
        public bool Muzzle { get; set; }

        [Display(Name = "Special Needs")]
        [DataType(DataType.MultilineText)]
        public string SpecialNeeds { get; set; }

        [Display(Name = "Sex")]
        [Required]
        [DataType(DataType.Text)]
        public string Sex { get; set; }
        [Display(Name = "Vaccinated")]
        [Required]
        public bool Vaccinated { get; set; }

        [Display(Name = "Vaccination Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime VaccinatedDate { get; set; }

        [Display(Name = "Groomed")]
        public bool Groomed { get; set; }

        public List<KennelVisit> KennelVisit { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}