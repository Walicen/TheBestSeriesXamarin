using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheBestSeries.Models;

namespace TheBestSeries.Services
{
    public class TMDbService : ITMDbService
    {
        //readonly IGameDbApi _api;

        //public GameService(IGameDbApi api)
        //{
        //    _api = api;
        //}

        //public Task<IEnumerable<Game>> GetGamesAsync()
        //{
        //    return _api.GetGamesAsync(AppSettings.ApiKey);
        //}
        public Task<IEnumerable<Series>> GetSeriesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
