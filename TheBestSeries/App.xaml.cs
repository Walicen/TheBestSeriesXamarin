using System;
using TheBestSeries.Services.Navigation;
using TheBestSeries.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TheBestSeries
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            BuildDependencies();
            InitNavigation();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzgxMUAzMTM2MmUzMjJlMzBIcnNlWEFSK3JJb3l3dXQwYnA2Nkc1ckxJbVlxTUFmWnpwNXJzK2YxdEhBPQ==");
            //MainPage = new NavigationPage( new Views.MainPage());
        }

        public void BuildDependencies()
        {
            ViewModelLocator.Instance.Build();
        }

        async void InitNavigation()
        {
            var navigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
            await navigationService.InitializeAsync();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
