using System.ComponentModel.DataAnnotations;

namespace DevNetCloud.Models.Forms
{
    public class RegisterForm
    {
        [EmailAddress]
        [Required(ErrorMessage = "Le Champ Email est requis")]
        [MaxLength(50)]
        public string Email { get; set; }


        [Required]
        [MinLength(8)]
        public string Password { get; set; }

    }
}
