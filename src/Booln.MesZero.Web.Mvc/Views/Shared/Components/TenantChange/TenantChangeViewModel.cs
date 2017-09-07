using Abp.AutoMapper;
using Booln.MesZero.Sessions.Dto;

namespace Booln.MesZero.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}