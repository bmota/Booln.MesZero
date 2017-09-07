using Abp.AutoMapper;
using Booln.MesZero.MultiTenancy.Dto;

namespace Booln.MesZero.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}