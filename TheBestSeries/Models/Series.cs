using System;
using Newtonsoft.Json;

namespace TheBestSeries.Models
{
    public class Series
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("vote_average")]
        public double Nota { get; set; }

        [JsonProperty("overview")]
        public string Sinopse { get; set; }

        [JsonProperty("poster_path")]
        public string Image { get; set; }

        [JsonProperty("backdrop_path")]
        public string Poster { get; set; }
    }
}
