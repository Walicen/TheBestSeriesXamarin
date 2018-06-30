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
        [Get("/tv/popular?api_key={apiKey}")]
        Task<SerieResponse> GetSeriesAsync(string apiKey);
    }
}
