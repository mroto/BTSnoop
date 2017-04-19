using BTSnoop.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTSnoop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsView : ContentPage
    {
        public SettingsView()
        {
            InitializeComponent();
            BindingContext = new SettingsViewModel();
        }
    }
}