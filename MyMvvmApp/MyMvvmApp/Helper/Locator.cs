using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using MyMvvmApp.Mvvm.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMvvmApp.Helper
{
    public class Locator
    {
        public Locator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<Mvvm.ViewModel.LoginViewModel>();
        }
        public LoginViewModel LoginViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginViewModel>();

            }
        }
    }
}
