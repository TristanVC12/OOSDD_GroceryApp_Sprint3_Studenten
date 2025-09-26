using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using Grocery.Core.Helpers;
using Grocery.App.Views;

namespace Grocery.App.ViewModels
{
    public partial class RegisterViewModel : BaseViewModel
    {
        private readonly IAuthService _authService;

        [ObservableProperty] private string name;
        [ObservableProperty] private string emailAddress;
        [ObservableProperty] private string password;
        [ObservableProperty] private string registerMessage;

        public RegisterViewModel(IAuthService authService, GlobalViewModel global)
        {
            _authService = authService;
            _global = global;
        }
        private readonly GlobalViewModel _global;


        [RelayCommand]
        private async Task Register()
        {
            var client = new Client(0, Name, EmailAddress, PasswordHelper.HashPassword(Password));
            bool success = _authService.Register(client);
            RegisterMessage = success ? "Registration successful!" : "Email already exists.";
            if (success)
            {
                // Go back to LoginView
                await Application.Current.MainPage.Navigation.PopAsync();
            }
        }
    }
}