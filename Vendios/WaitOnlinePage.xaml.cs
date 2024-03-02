using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Vendios
{
    public sealed partial class WaitOnlinePage : Page
    {
        private UtilitiesTimer _timer;
        public WaitOnlinePage()
        {
            this.InitializeComponent();
            _timer = new UtilitiesTimer(textTimerBlock, Frame);
            _timer.RegisterBackgroundTask();
            _timer.StartTimer();
        }

        private void AutorizationButtonPage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AuthorizationPage));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
