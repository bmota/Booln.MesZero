using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Booln.MesZero.MultiTenancy.HostDashboard.Dto;

namespace Booln.MesZero.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}