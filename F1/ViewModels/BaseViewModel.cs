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
        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

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