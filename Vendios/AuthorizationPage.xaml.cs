using System;
using System.Net.Http;
using System.Text;
using Windows.UI.Xaml.Controls;

namespace Vendios
{
    public sealed partial class AuthorizationPage : Page
    {
        private const string AuthorizationUrl = "https://ferma-test.ofd.ru/api/Authorization/CreateAuthToken";

        public AuthorizationPage()
        {
            this.InitializeComponent();
        }

        private async void AuthorizationButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var manager = new APIManager.GetAuthorization();
            string login = "fermatest1";
            string password = "Hjsf3321klsadfAA";
            string result = await manager.PerformAuthorizationAsync(login, password);
            ResultTextBox.Text = result;
        }

    }
}
