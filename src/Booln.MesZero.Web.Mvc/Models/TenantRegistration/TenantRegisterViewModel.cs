using Booln.MesZero.Editions;
using Booln.MesZero.Editions.Dto;
using Booln.MesZero.Security;
using Booln.MesZero.MultiTenancy.Payments;
using Booln.MesZero.MultiTenancy.Payments.Dto;

namespace Booln.MesZero.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType? Gateway { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public bool ShowPaymentExpireNotification()
        {
            return !string.IsNullOrEmpty(PaymentId);
        }
    }
}
