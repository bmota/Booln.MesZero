using Booln.MesZero.Authorization.Accounts.Dto;

namespace Booln.MesZero.Web.Models.Account
{
    public class EmailConfirmationViewModel : ActivateEmailInput
    {
        /// <summary>
        /// Tenant id.
        /// </summary>
        public int? TenantId { get; set; }
    }
}