using System;
using System.Collections.Generic;
using TheBestSeries.Models;
using TheBestSeries.ViewModels.Base;

namespace TheBestSeries.ViewModels
{
    public class ListViewModel : ViewModelBase
    {
        public List<Series> Series { get; set; }

        public ListViewModel(): base("TheBestSeries")
        {
            this.Series = new ListMovie().Filmes;
        }


    }
}
