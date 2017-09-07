using Abp.AutoMapper;
using Booln.MesZero.Web.Authentication.External;

namespace Booln.MesZero.Web.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
