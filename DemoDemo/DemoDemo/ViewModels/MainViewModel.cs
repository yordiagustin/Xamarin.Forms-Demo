using DemoDemo.Models;
using DemoDemo.Views;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoDemo.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private User _user;

        public static Data.Data UserData;

        public ICommand RegisterCommand { get; set; }
        public ICommand ViewCommand { get; set; }

        public INavigation Navigation { get; set; }

        public User User
        {
            get { return _user; }
            set { _user = value; OnPropertyChanged(); }
        }

        public MainViewModel(INavigation navigation)
        {
            RegisterCommand = new Command(Register);
            ViewCommand = new Command(NavigateTo);
            Navigation = navigation;
            _user = new User();
            UserData = new Data.Data();
        }

        private async void NavigateTo(object obj)
        {
           await Navigation.PushModalAsync(new SecondPage());          
        }

        private async void Register(object obj)
        {
            UserData.AddUser(_user);
            await App.Current.MainPage.DisplayAlert("Usuario Registrado", "Usuario Registrado Exitosamente...", "Ok!");
            await Navigation.PushModalAsync(new SecondPage());
        }
    }
}
