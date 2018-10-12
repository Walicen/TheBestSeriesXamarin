using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using TheBestSeries.Models;
using TheBestSeries.Services;
using TheBestSeries.ViewModels.Base;
using Xamarin.Forms;

namespace TheBestSeries.ViewModels
{
    public class ListViewModel : ViewModelBase
    {
        //public List<Serie> Series { get; set; }

        readonly ISerieService _serieServices;

        public ICommand ItemClickCommand { get; }

        public ObservableCollection<Serie> Items { get; }

        public ListViewModel(ISerieService serieService): base("TheBestSeries")
        {
            _serieServices = serieService;

            Items = new ObservableCollection<Serie>();

            ItemClickCommand = new Command<Serie>(async (item) => await ItemClickCommandExecute(item)); 
           
            //this.Series = new ListMovie().Filmes;
        }

        private async Task ItemClickCommandExecute(Serie item)
        {
            if(item != null)
            {
                await NavigationService.NavigateToAsync<DetailsViewModel>(item);
            }
        }

        public override async Task InitializeAsync(object navigationData)
        {
            await base.InitializeAsync(navigationData);

            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            var result = await _serieServices.GetSeriesAsync();

            AddItems(result);
        }

        private void AddItems(SerieResponse result)
        {
            Items.Clear();
            result?.Series.ToList()?.ForEach(i => Items.Add(i));
        }
    }
}
