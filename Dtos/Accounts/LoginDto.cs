using System.ComponentModel.DataAnnotations;

namespace AspApi.Dtos.Accounts
{
    public class LoginDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
