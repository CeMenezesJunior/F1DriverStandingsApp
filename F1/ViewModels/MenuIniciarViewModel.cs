using System;
using System.Net.Http;
using System.Threading.Tasks;
using F1.Models;
using F1.Views;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Navigation;

namespace F1.ViewModels
{
    public class MenuIniciarViewModel:BaseViewModel
    {
        DelegateCommand _mPilotos;
        public DelegateCommand MPilotos => _mPilotos
            ?? (_mPilotos = new DelegateCommand(async () => await ExecuteMPilotos()));

        DelegateCommand _mConstructor;
        public DelegateCommand MConstructors => _mConstructor
            ?? (_mConstructor = new DelegateCommand(async () => await ExecuteMConstructor()));

        public MenuIniciarViewModel(INavigationService navigationService) :
            base(navigationService)
        {
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            HttpClient client = new HttpClient();

            var DriverJson = await client.GetStringAsync("https://a1f5f75c-a0c7-4924-b16d-7a9af7b4f885.mock.pstmn.io/F1?Drivers");
            App.Drivers = JsonConvert.DeserializeObject<DriversList>(DriverJson);

            var TeamJson = await client.GetStringAsync("https://a1f5f75c-a0c7-4924-b16d-7a9af7b4f885.mock.pstmn.io/F1?Teams");
            App.Teams = JsonConvert.DeserializeObject<TeamsList>(TeamJson);
        }
        private async Task ExecuteMPilotos()
        {
            await NavigationService.NavigateAsync(nameof(MainPage));
        }
        private async Task ExecuteMConstructor()
        {
            await NavigationService.NavigateAsync(nameof(ConstructorPage));
        }
    }
}
