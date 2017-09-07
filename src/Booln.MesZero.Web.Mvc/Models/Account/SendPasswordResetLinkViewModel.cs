using System.ComponentModel.DataAnnotations;

namespace Booln.MesZero.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}