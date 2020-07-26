using System;
using System.Linq;
using F1.Models;
using F1.Services;
using Prism.Navigation;

namespace F1.ViewModels
{
    public class MainPageViewModel:BaseViewModel
    {
        
        public MainPageViewModel(INavigationService navigationService):
            base(navigationService)
        {

        }
        
    }
}
