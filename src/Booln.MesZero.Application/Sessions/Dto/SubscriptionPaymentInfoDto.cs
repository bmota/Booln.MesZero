using Abp.AutoMapper;
using Booln.MesZero.MultiTenancy.Payments;

namespace Booln.MesZero.Sessions.Dto
{
    [AutoMapFrom(typeof(SubscriptionPayment))]
    public class SubscriptionPaymentInfoDto
    {
        public decimal Amount { get; set; }
    }
}