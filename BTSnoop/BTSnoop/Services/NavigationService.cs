namespace BTSnoop.Services.Navigation
{
    using System;
    using System.Collections.Generic;
    using ViewModels;
    using Views;
    using Xamarin.Forms;

    public class NavigationService
    {
        private static NavigationService _instance;
        private IDictionary<Type, Type> viewModelRouting = new Dictionary<Type, Type>()
        {
            //VIEW MODELS - VIEWS:
            { typeof(MainViewModel),  typeof(MainView) },
            { typeof(SettingsViewModel), typeof(SettingsView) }
        };

        public static NavigationService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NavigationService();
                }

                return _instance;
            }
        }

        public void NavigateTo<TDestinationViewModel>(bool animated, object navigationContext = null)
        {
            Type pageType = viewModelRouting[typeof(TDestinationViewModel)];
            var page = Activator.CreateInstance(pageType) as Page;

            if (page != null)
                Application.Current.MainPage.Navigation.PushAsync(page, animated);
        }

        public void NavigateTo(Type destinationType, bool animated, object navigationContext = null)
        {
            Type pageType = viewModelRouting[destinationType];
            var page = Activator.CreateInstance(pageType, navigationContext) as Page;

            if (page != null)
                Application.Current.MainPage.Navigation.PushAsync(page, animated);
        }

        public void NavigateBack(bool animated)
        {
            Application.Current.MainPage.Navigation.PopAsync(animated);
        }

        public void NavigateBackToRoot(bool animated)
        {
            Application.Current.MainPage.Navigation.PopToRootAsync(animated);
        }
    }
}