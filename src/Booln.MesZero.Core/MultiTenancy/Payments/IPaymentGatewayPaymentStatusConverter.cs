namespace Booln.MesZero.MultiTenancy.Payments
{
    public interface IPaymentGatewayPaymentStatusConverter
    {
        SubscriptionPaymentStatus ConvertToSubscriptionPaymentStatus(string externalStatus);
    }
}