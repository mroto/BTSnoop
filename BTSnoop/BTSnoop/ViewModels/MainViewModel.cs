using BTSnoop.Services.Navigation;
using System.Windows.Input;
using Xamarin.Forms;

namespace BTSnoop.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        public ICommand SettingsCommand { get; protected set; }

        public MainViewModel()
        {
            SettingsCommand = new Command(param => OpenSettings());
        }

        private void OpenSettings()
        {
            NavigationService.Instance.NavigateTo<SettingsViewModel>(true);
        }
    }
}