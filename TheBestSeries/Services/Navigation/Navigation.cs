using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using TheBestSeries.ViewModels.Base;
using System.Collections.Generic;
using TheBestSeries.ViewModels;
using TheBestSeries.Views;

namespace TheBestSeries.Services.Navigation
{
    public class Navigation : INavigation
    {
        protected readonly Dictionary<Type, Type> _mappings;

        protected Application CurrentApplication
        {
            get { return Application.Current; }
        }

        public Navigation()
        {
            _mappings = new Dictionary<Type, Type>();
            CreatePageViewModelMappings();
        }

        private void CreatePageViewModelMappings()
        {
            _mappings.Add(typeof(ListViewModel), typeof(MainPage));
            _mappings.Add(typeof(DetailsViewModel), typeof(DetailsView));
        }

        public Task InitializeAsync()
        {
            throw new NotImplementedException();
        }

        public Task NavigateAndClearBackStackAsync<TViewModel>(object parameter = null) where TViewModel : ViewModelBase
        {
            throw new NotImplementedException();
        }

        public Task NavigateBackAsync()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync(Type viewModelType)
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync(Type viewModelType, object parameter)
        {
            throw new NotImplementedException();
        }

        #region not Implemented

        public Task RemoveLastFromBackStackAsync()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
