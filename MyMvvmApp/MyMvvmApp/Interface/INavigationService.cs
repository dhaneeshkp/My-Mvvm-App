using MyMvvmApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMvvmApp.Interface
{
  public  interface INavigationService
    {
        void GoBack();
        void NavigateTo(AppPages pageKey);
        void NavigateTo(AppPages pageKey, object parameter);
    }
}
