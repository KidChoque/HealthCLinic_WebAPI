using System.ComponentModel.DataAnnotations;

namespace HealthClinic_WebAPI_Lucas.ViewModels
{
    public class LoginViewModels
    {
        [Required(ErrorMessage = "Email obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha obrigatório!")]
        public string Senha { get; set; }
    }
}
