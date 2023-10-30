using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ContactPro.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        public string? AppUserID { get; set; }
        [Required]
        [Display(Name ="First Name")]
        [StringLength(50,ErrorMessage ="The {0} must be at least {2} and a max of {1} characters long.",MinimumLength =2)]
        public string? FirstName   { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and a max of {1} characters long.", MinimumLength = 2)]
        public string? LastName { get; set; }

    }
}
