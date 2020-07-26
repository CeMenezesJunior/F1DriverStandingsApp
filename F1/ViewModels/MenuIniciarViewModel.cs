using System;
using System.Threading.Tasks;
using F1.Views;
using Prism.Commands;
using Prism.Navigation;

namespace F1.ViewModels
{
    public class MenuIniciarViewModel:BaseViewModel
    {
        DelegateCommand _mPilotos;
        public DelegateCommand MPilotos => _mPilotos
            ?? (_mPilotos = new DelegateCommand(async () => await ExecuteMPilotos()));
        public MenuIniciarViewModel(INavigationService navigationService) :
            base(navigationService)
        {
        }
        private async Task ExecuteMPilotos()
        {
            await navigationService.NavigateAsync(nameof(MainPage));
        }
    }
}
