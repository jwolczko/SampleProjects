using System.Collections.ObjectModel;
using System.Windows.Input;
using Prism.Mvvm;
using SimpleWPFApp.Model;
using Ninject;
using Ninject.Parameters;
using System;
using System.Windows;


namespace SimpleWPFApp.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        private IKernel _karnel;
        public string AppTitle => AppConsts.AppTitle;

        public ICommand SavePackagesCommand { get; private set; }
        public ICommand CancelChangesCommand { get; private set; }
        public ICommand LoadPackagesCommand { get; private set; }

        public ObservableCollection<Package> Packages { get; }

        public MainWindowViewModel(IKernel kernel)
        {
            _karnel = kernel;
            SavePackagesCommand = _karnel.Get<ICommand>(AppConsts.SavePackages, new ConstructorArgument("viewModel", this));
            CancelChangesCommand = _karnel.Get<ICommand>(AppConsts.LoadPackages, new ConstructorArgument("viewModel", this));
            LoadPackagesCommand = _karnel.Get<ICommand>(AppConsts.LoadPackages, new ConstructorArgument("viewModel", this));
            Packages = new ObservableCollection<Package>();
        }

        public void OnException(Exception exception)
        {
            MessageBox.Show(exception.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
        }        
    }
}
