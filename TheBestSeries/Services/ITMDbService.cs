using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheBestSeries.Models;

namespace TheBestSeries.Services
{
    public interface ITMDbService
    {
        Task<IEnumerable<Series>> GetSeriesAsync();
    }
}
