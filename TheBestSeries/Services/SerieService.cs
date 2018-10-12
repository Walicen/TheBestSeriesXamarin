using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheBestSeries.Infrastructure.Api;
using TheBestSeries.Models;

namespace TheBestSeries.Services
{
    public class SerieService : ISerieService
    {
        readonly ITMDbApi _api;

        public SerieService(ITMDbApi api)
        {
            _api = api;    
        }

       

        public async Task<SerieResponse> GetSeriesAsync()
        {
            return await _api.GetSeriesAsync(ApiSettings.ApiKey);
        }
    }
}
