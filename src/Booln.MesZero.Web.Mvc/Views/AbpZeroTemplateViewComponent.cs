using Abp.AspNetCore.Mvc.ViewComponents;

namespace Booln.MesZero.Web.Views
{
    public abstract class AbpZeroTemplateViewComponent : AbpViewComponent
    {
        protected AbpZeroTemplateViewComponent()
        {
            LocalizationSourceName = AbpZeroTemplateConsts.LocalizationSourceName;
        }
    }
}