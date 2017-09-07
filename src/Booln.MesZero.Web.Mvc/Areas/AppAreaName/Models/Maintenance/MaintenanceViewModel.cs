using System.Collections.Generic;
using Booln.MesZero.Caching.Dto;

namespace Booln.MesZero.Web.Areas.AppAreaName.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}