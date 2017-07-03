using GalaSoft.MvvmLight;
using MyMvvmApp.Interface;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyMvvmApp.Droid.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        private readonly INavigationService _navigationService;
        public ICommand NavigateCommand { get; private set; }
        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new Command(() => Navigate()); 
        }

        private void Navigate()
        {
            _navigationService.NavigateTo(Enums.AppPages.loginView);
        }
    }
}
