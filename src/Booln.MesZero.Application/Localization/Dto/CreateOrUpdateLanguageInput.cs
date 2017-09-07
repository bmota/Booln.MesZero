using System.ComponentModel.DataAnnotations;

namespace Booln.MesZero.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}