using Xamarin.Forms;

namespace BTSnoop.ViewModels
{
    public class BaseViewModel : BindableObject
    {
        public void OnPropertyChanged(object property)
        {
            base.OnPropertyChanged(nameof(property));
        }
    }
}