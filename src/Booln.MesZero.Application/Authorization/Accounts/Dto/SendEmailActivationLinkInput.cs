using System.ComponentModel.DataAnnotations;

namespace Booln.MesZero.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}