using System;
using System.Collections.Generic;
using System.Linq;
using F1.Models;
using F1.Services;
using Prism.Navigation;

namespace F1.ViewModels
{
    public class MainPageViewModel:BaseViewModel
    {
        List<Driver> _drivers;
        public List<Driver> Drivers { get => _drivers; set => SetProperty(ref _drivers, value); }

        public MainPageViewModel(INavigationService navigationService):
            base(navigationService)
        {
            Drivers = new List<Driver>();
            Drivers = App.Season2020.DriversStanding;
        }
        
    }
}
