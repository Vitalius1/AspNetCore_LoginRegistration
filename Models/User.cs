using System.ComponentModel.DataAnnotations;
 
namespace LoginRegistration.Models
{
    public class User : BaseEntity
    {
        [Display(Name = "First Name")]
        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 letters.")]
        [RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Must be letters only.")]
        public string FirstName {get; set;}
        
        [Display(Name = "Last Name")]
        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 letters.")]
        [RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Must be letters only.")]
        public string LastName {get; set;}
        
        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email {get; set;}
        
        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters.")]
        public string Password {get; set;}

        [Display(Name = "Confirm Password")]
        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters.")]
        public string ConfirmPassword {get; set;}

    }
}