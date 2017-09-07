using System.ComponentModel.DataAnnotations;

namespace Booln.MesZero.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
