using System.Threading.Tasks;
using Booln.MesZero.Security.Recaptcha;

namespace Booln.MesZero.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public async Task ValidateAsync(string captchaResponse)
        {
            
        }
    }
}
