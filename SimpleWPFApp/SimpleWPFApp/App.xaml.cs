using Ninject;
using SimpleWPFApp.Command;
using SimpleWPFApp.Repository;
using SimpleWPFApp.ViewModel;
using System.Windows;
using System.Windows.Input;

namespace SimpleWPFApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IKernel container;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureContainer();
            ComposeObjects();
            Current.MainWindow.Show();
        }

        private void ConfigureContainer()
        {
            this.container = new StandardKernel();
            this.container.Bind<ICommandPackageRepository>().To<CommandPackageRepository>();
            this.container.Bind<IQueryPackageRepository>().To<QueryPackageRepository>();
            this.container.Bind<ICommand>().To<LoadPackagesCommand>().Named(AppConsts.LoadPackages);
            this.container.Bind<ICommand>().To<SavePackagesCommand>().Named(AppConsts.SavePackages);
            this.container.Bind<MainWindowViewModel>().ToSelf().InSingletonScope();
        }

        private void ComposeObjects()
        {
            Current.MainWindow = this.container.Get<MainWindow>();
            Current.MainWindow.DataContext = this.container.Get<MainWindowViewModel>();
        }

        private void ApplicationDispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show($"An unhandled exception just occurred: {e.Exception.Message}", "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }
    }
}
