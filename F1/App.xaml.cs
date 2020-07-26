using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using F1.Views;
using Prism.DryIoc;
using Prism;
using Prism.Ioc;
using F1.ViewModels;
using F1.Services;
using F1.Models;

namespace F1
{
    public partial class App : PrismApplication
    {
        public static Season Season2020 { get; set; }

        public App() : this(null)
        {



        }

        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
        }

        public App(IPlatformInitializer initializer, bool setFormsDependencyResolver)
            : base(initializer, setFormsDependencyResolver)
        {

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<MenuIniciar, MenuIniciarViewModel>();
            containerRegistry.RegisterForNavigation<ConstructorPage, ConstructorPageViewModel>();
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            var SH = new SeasonHandle();
            Season2020 = SH.Season;
            await NavigationService.NavigateAsync(nameof(MenuIniciar));
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}