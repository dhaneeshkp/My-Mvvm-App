using MyMvvmApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyMvvmApp.Interface
{
  public  interface INavigationService
    {
        void GoBack();
        void NavigateTo(AppPages pageKey);
        void NavigateTo(AppPages pageKey, object parameter);
        void Configure(AppPages pageKey, Type type);
        void Initialize(NavigationPage navigation);
    }
}
