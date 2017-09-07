using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Booln.MesZero.Web.Areas.AppAreaName.Models.Layout;
using Booln.MesZero.Web.Session;
using Booln.MesZero.Web.Views;

namespace Booln.MesZero.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameFooter
{
    public class AppAreaNameFooterViewComponent : AbpZeroTemplateViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameFooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
