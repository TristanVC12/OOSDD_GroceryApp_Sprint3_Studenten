using Grocery.App.ViewModels;
using Grocery.App.Views;
using Grocery.Core.Services;
using Grocery.Core.Data.Repositories;   

namespace Grocery.App
{
    public partial class App : Application
    {
        public App(LoginViewModel viewModel)
        {
            InitializeComponent();

            var globalViewModel = new GlobalViewModel();
            var clientRepository = new ClientRepository();
            var clientService = new ClientService(clientRepository);
            var authService = new AuthService(clientService);
            var loginViewModel = new LoginViewModel(authService, globalViewModel);
            

            MainPage = new NavigationPage(new LoginView(loginViewModel, authService, globalViewModel));
        }
    }
}
