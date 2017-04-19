using BTSnoop.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTSnoop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}