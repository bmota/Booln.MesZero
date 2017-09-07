using Abp.AspNetCore.Mvc.Authorization;
using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;
using Booln.MesZero.Authorization;
using Booln.MesZero.Web.Controllers;

namespace Booln.MesZero.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}