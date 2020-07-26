using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using F1.Models;
using F1.Services;
using Prism;
using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;


namespace F1.ViewModels
{
    public class BaseViewModel : BindableBase, IInitializeAsync, INavigatedAware, IAutoInitialize, IActiveAware, IDestructible
    {
        Race Austria1 = new Race();
        Race Austria2 = new Race();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        List<Driver> _drivers;
        public List<Driver> Drivers { get => _drivers; set => SetProperty(ref _drivers, value); }

        protected readonly INavigationService navigationService;

        public event EventHandler IsActiveChanged;

        public BaseViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        public void InsereDrivers()
        {
            Drivers = new List<Driver> {
                new Driver { Name = "Hamilton", Team = "Mercedes", Point = 0 },//0
                new Driver{ Name="Bottas", Team="Mercedes", Point=0},//1
                new Driver{ Name="Leclerc", Team="Ferrari", Point=0},//2
                new Driver{ Name="Vettel", Team="Ferrari", Point=0},//3
                new Driver{ Name="Verstappen", Team="RBR", Point=0},//4
                new Driver{ Name="Albol", Team="RBR", Point=0},//5
                new Driver{ Name="Ricciardo", Team="Renault", Point=0},//6
                new Driver{ Name="Ocon", Team="Renault", Point=0},//7
                new Driver{ Name="Raikkonen", Team="Alfa Romeo", Point=0},//8
                new Driver{ Name="Giovinazzi", Team="Alfa Romeo", Point=0},//9
                new Driver{ Name="Gasly", Team="Alfa Tauri", Point=0},//10
                new Driver{ Name="Kvyat", Team="Alfa Tauri", Point=0},//11
                new Driver{ Name="Grosjean", Team="Haas", Point=0},//12
                new Driver{ Name="Magnussen", Team="Haas", Point=0},//13
                new Driver{ Name="Norris", Team="Mclaren", Point=0},//14
                new Driver{ Name="Sainz", Team="Mclaren", Point=0},//15
                new Driver{ Name="Perez", Team="Racing Point", Point=0},//16
                new Driver{ Name="Stroll", Team="Racing Point", Point=0},//17
                new Driver{ Name="Russell", Team="Williams", Point=0},//18
                new Driver{ Name="Latifi", Team="Williams", Point=0}//19
            };
        }

        public void InsereAustria1()
        {
            Austria1.Positions.Add(Drivers[1]);
            Austria1.Positions.Add(Drivers[2]);
            Austria1.Positions.Add(Drivers[14]);
            Austria1.Positions.Add(Drivers[0]);
            Austria1.Positions.Add(Drivers[15]);
            Austria1.Positions.Add(Drivers[16]);
            Austria1.Positions.Add(Drivers[10]);
            Austria1.Positions.Add(Drivers[7]);
            Austria1.Positions.Add(Drivers[9]);
            Austria1.Positions.Add(Drivers[3]);
            new Points(Austria1, Drivers[14]);
        }
        public void InsereAustria2()
        {
            Austria2.Positions.Add(Drivers[0]);
            Austria2.Positions.Add(Drivers[1]);
            Austria2.Positions.Add(Drivers[4]);
            Austria2.Positions.Add(Drivers[5]);
            Austria2.Positions.Add(Drivers[14]);
            Austria2.Positions.Add(Drivers[16]);
            Austria2.Positions.Add(Drivers[17]);
            Austria2.Positions.Add(Drivers[6]);
            Austria2.Positions.Add(Drivers[15]);
            Austria2.Positions.Add(Drivers[10]);
            new Points(Austria2, Drivers[15]);
        }

        public bool IsActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task InitializeAsync(INavigationParameters parameters) => Task.CompletedTask;
    }
}