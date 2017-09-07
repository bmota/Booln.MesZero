using Booln.MesZero.Editions;
using Booln.MesZero.MultiTenancy.Payments;

namespace Booln.MesZero.Web.Models.Payment
{
    public class CreatePaymentModel
    {
        public int EditionId { get; set; }

        public PaymentPeriodType? PaymentPeriodType { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}
