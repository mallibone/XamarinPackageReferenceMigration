using System.Threading.Tasks;
using HelloNetStandard.ViewModels;
using Xamarin.Forms;

namespace HelloNetStandard.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private async Task ShowDialogMessage(string message)
        {
            await ShowDialogMessage(message);
        }
    }
}
