using System;
using Autofac;
using Refit;
using TheBestSeries.Services;
using TheBestSeries.Services.Navigation;

namespace TheBestSeries.ViewModels.Base
{
    public class ViewModelLocator
    {
        IContainer _container;
        ContainerBuilder _containerBuilder;

        static readonly ViewModelLocator _instance = new ViewModelLocator();

        public static ViewModelLocator Instance
        {
            get
            {
                return _instance;
            }
        }

        public ViewModelLocator()
        {
            _containerBuilder = new ContainerBuilder();

            _containerBuilder.RegisterType<NavigationService>().As<INavigationService>();
            //_containerBuilder.RegisterType<DialogService>().As<IDialogService>();
            //_containerBuilder.RegisterType<ITMDbService>().As<TMDbService>();

            _containerBuilder.RegisterType<ListViewModel>();
            _containerBuilder.RegisterType<DetailsViewModel>();

            //_containerBuilder.Register(api =>
            //{
            //    var client = new HttpClient(new HttpLoggingHandler())
            //    {
            //        BaseAddress = new Uri(AppSettings.ApiUrl),
            //        Timeout = TimeSpan.FromSeconds(60)
            //    };

            //    return RestService.For<IGameDbApi>(client);
            //}).As<IGameDbApi>().InstancePerDependency();
        }

        public T Resolve<T>() => _container.Resolve<T>();
        public object Resolve(Type type) => _container.Resolve(type);
        public void Register<TInterface, TImplementation>() where TImplementation : TInterface => _containerBuilder.RegisterType<TImplementation>().As<TInterface>();
        public void Register<T>() where T : class => _containerBuilder.RegisterType<T>();

        public void Build()
        {
            if (_container == null)
                _container = _containerBuilder.Build();
        }
    }
}
