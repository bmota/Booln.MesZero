using System.Threading.Tasks;

namespace Booln.MesZero.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}