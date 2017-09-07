using Abp.AutoMapper;
using Booln.MesZero.Editions;
using Booln.MesZero.MultiTenancy.Payments.Dto;

namespace Booln.MesZero.Web.Areas.AppAreaName.Models.SubscriptionManagement
{
    [AutoMapTo(typeof(ExecutePaymentDto))]
    public class PaymentResultViewModel : SubscriptionPaymentDto
    {
        public EditionPaymentType EditionPaymentType { get; set; }
    }
}