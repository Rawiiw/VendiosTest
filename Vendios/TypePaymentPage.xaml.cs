using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Vendios
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class TypePaymentPage : Page
    {
        public TypePaymentPage()
        {
            this.InitializeComponent();
        }

        private void BtnCash_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WaitCashPage));
        }

        private void BtnOnline_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WaitOnlinePage));
        }
    }
}
