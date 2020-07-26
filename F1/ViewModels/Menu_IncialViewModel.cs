using System;
using System.Threading.Tasks;
using F1.Views;
using Prism.Commands;
using Prism.Navigation;

namespace F1.ViewModels
{
    public class Menu_IncialViewModel:BaseViewModel
    {
        DelegateCommand _pilotos;
        DelegateCommand MPilotos => _pilotos
            ?? (_pilotos = new DelegateCommand(async () => await ExecutePilotos()));

        public Menu_IncialViewModel(INavigationService navigationService) :
            base(navigationService)
        {

        }
        private async Task ExecutePilotos()
        {
            await navigationService.NavigateAsync(nameof(MainPage));
        }
    }
}
