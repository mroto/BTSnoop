using BTSnoop.Services.Navigation;
using System.Windows.Input;
using Xamarin.Forms;

namespace BTSnoop.ViewModels
{
    class SettingsViewModel : BaseViewModel
    {
        public ICommand BackCommand { get; protected set; }

        public SettingsViewModel()
        {
            BackCommand = new Command(param => GoBack());
        }

        private void GoBack()
        {
            NavigationService.Instance.NavigateBack(true);
        }
    }
}