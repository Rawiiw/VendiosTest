using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Vendios
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    // <ActivatableClass ActivatableClassId="VendiosRuntime.TimerBackgroundTask" ThreadingModel="both" /> в манифесте потому как UPW перестала поддерживать ассинхронность, манифест автогенерируем
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }

        private void ButtonPayment_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TypePaymentPage));

        }
    }
}
