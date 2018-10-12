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
        [Get("/tv/top_rated?api_key={apiKey}&language=pt-BR")]
        Task<SerieResponse> GetSeriesAsync(string apiKey);
    }
}
