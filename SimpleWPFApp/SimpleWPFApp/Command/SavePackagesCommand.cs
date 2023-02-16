using Ninject;
using SimpleWPFApp.Repository;
using SimpleWPFApp.ViewModel;
using System.Threading.Tasks;

namespace SimpleWPFApp.Command
{
    public class SavePackagesCommand : AsyncMainWindowCommandBase
    {
        ICommandPackageRepository commandPackageRepository;
        public SavePackagesCommand(IKernel kernel, MainWindowViewModel viewModel) 
            : base(kernel, viewModel)
        {
            commandPackageRepository =  _kernel.Get<ICommandPackageRepository>();
        }

        protected override async Task ExecuteAsync(object parameter)
        {
            await commandPackageRepository.SavePackagesAsync(_viewModel.Packages);
            _viewModel.LoadPackagesCommand.Execute(parameter);
        }
    }
}
