using System;
using System.Threading.Tasks;
using TheBestSeries.Models;
using TheBestSeries.ViewModels.Base;

namespace TheBestSeries.ViewModels
{
    public class DetailsViewModel : ViewModelBase
    {

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private string _backdrop;
        public string Backdrop
        {
            get { return _backdrop; }
            set { _backdrop = value; OnPropertyChanged(); }
        }
        private double _votes;
        public double Votes
        {
            get { return _votes; }
            set { _votes = value; OnPropertyChanged(); }
        }
        private string _overview;
        public string Overview
        {
            get { return _overview; }
            set { _overview = value; OnPropertyChanged(); }
        }

        private string _firstDate;
        public string FirstDate
        {
            get { return _firstDate; }
            set { _firstDate = value; OnPropertyChanged(); }
        }



        public DetailsViewModel() : base("")
        {
        }

        public override async Task InitializeAsync(object parameter)
        {

            var serie = (parameter as Serie);

            Name = serie.Name;
            Votes = serie.VoteAverage;
            Backdrop = serie.BackdropPath;
            Overview = serie.Overview;
            FirstDate = serie.ReleaseDate;


            await base.InitializeAsync(parameter);


        }
    }
}
