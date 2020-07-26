using System;
using System.Collections.Generic;
using F1.Models;
using Prism.Navigation;

namespace F1.ViewModels
{
    public class ConstructorPageViewModel : BaseViewModel
    {
        List<Team> _teams;
        public List<Team> Teams { get => _teams; set => SetProperty(ref _teams, value); }

        public ConstructorPageViewModel(INavigationService navigationService) :
            base(navigationService)
        {
            Teams = new List<Team>();
            Teams = App.Season2020.TeamStanding;
        }
    }
}
