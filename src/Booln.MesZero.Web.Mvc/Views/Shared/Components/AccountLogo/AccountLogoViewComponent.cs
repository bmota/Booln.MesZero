using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Booln.MesZero.Web.Session;

namespace Booln.MesZero.Web.Views.Shared.Components.AccountLogo
{
    public class AccountLogoViewComponent : AbpZeroTemplateViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AccountLogoViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            return View(new AccountLogoViewModel(loginInfo));
        }
    }
}
