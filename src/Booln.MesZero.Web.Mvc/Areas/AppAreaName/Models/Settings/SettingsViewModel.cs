using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Booln.MesZero.Configuration.Tenants.Dto;

namespace Booln.MesZero.Web.Areas.AppAreaName.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}