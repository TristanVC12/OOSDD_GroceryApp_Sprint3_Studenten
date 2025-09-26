using Grocery.Core.Interfaces.Services;
using Grocery.App.ViewModels;
using Grocery.App.Views;

namespace Grocery.App.Views;

public partial class LoginView : ContentPage
{
    public LoginView(LoginViewModel viewModel, IAuthService authService, GlobalViewModel global)
    {
        InitializeComponent();
        BindingContext = viewModel;
        _authService = authService;
        _global = global;
    }
    private readonly IAuthService _authService;
    private readonly GlobalViewModel _global;
	
    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterView(_authService, _global));
    }
	
}