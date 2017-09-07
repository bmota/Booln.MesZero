using System.ComponentModel.DataAnnotations;
using Booln.MesZero.Authorization.Users;

namespace Booln.MesZero.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}