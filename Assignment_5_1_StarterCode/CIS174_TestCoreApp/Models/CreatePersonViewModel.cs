using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class CreatePersonViewModel
    {
        [Required]
        [StringLength(25)]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(25)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Range (1,120)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [EmailAddress]
        [Compare(nameof(Email))]
        public string ConfirmEmail { get; set; }

        [MinLength(7)]
        [Url]
        public string Website { get; set; }
        
        [Editable (false, AllowInitialValue = true)]
        [ReadOnly (true)]
        public string School { get;  set; }
    }
}
