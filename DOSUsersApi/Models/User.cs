using System;
using System.ComponentModel.DataAnnotations;

namespace DOSUsersApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }      
        
        [Required]
        [MaxLength(250)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [MaxLength(250)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [MaxLength(250)]
        public string City { get; set; }

        [Required]
        [MaxLength(250)]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
    }
}
