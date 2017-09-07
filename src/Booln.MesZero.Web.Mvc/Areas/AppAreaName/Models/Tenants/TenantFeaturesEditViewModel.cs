using Abp.AutoMapper;
using Booln.MesZero.MultiTenancy;
using Booln.MesZero.MultiTenancy.Dto;
using Booln.MesZero.Web.Areas.AppAreaName.Models.Common;

namespace Booln.MesZero.Web.Areas.AppAreaName.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}