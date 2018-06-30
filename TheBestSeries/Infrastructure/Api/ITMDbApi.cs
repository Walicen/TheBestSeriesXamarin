using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using TheBestSeries.Models;

namespace TheBestSeries.Infrastructure.Api
{
    [Headers("Content-Type: application/json")]
    public interface ITMDbApi
    {
        [Get("?api_key=")]
        Task<IEnumerable<Series>> GetSeriesAsync([Header("user-key")] string authorization);
    }
}
