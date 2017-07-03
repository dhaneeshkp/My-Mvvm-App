using GalaSoft.MvvmLight.Ioc;
using MyMvvmApp.Droid.ViewModel;
using MyMvvmApp.Enums;
using MyMvvmApp.Interface;
using MyMvvmApp.Mvvm.View;
using MyMvvmApp.Services;
using System;
using Xamarin.Forms;

namespace MyMvvmApp
{
    public class AppStart : Application

    {
        private static  ViewModelLocator _locator;
        INavigationService _navigationService;
        public static  ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }
        public AppStart()
        {
            INavigationService navigationService;

            if (!SimpleIoc.Default.IsRegistered<INavigationService>())
            {
                // Setup navigation service:
                _navigationService = new NavigationService();

                SimpleIoc.Default.Register<INavigationService>(() => _navigationService);
            }

            else
                _navigationService = SimpleIoc.Default.GetInstance<INavigationService>();

            // Create new Navigation Page and set MainPage as its default page:
            var firstPage = new NavigationPage(new LoginView());
            // Set Navigation page as default page for Navigation Service:
            _navigationService.Initialize(firstPage);
            // You have to also set MainPage property for the app:
            MainPage = firstPage;
        }
        private void RegisterViews()
        {
            // Configure pages:
            _navigationService.Configure(AppPages.loginView, typeof(LoginView));

        }

    }
}



