using Grocery.App.ViewModels;
using Grocery.Core.Interfaces.Services;

namespace Grocery.App.Views
{
    public partial class RegisterView : ContentPage
    {
        public RegisterView(IAuthService authService, GlobalViewModel global)
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel(authService, global);
        }

    }
}