using Ninject;
using SimpleWPFApp.Repository;
using SimpleWPFApp.ViewModel;
using System.Threading.Tasks;

namespace SimpleWPFApp.Command
{
    internal class LoadPackagesCommand : AsyncMainWindowCommandBase
    {
        
        IQueryPackageRepository _queryPackageRepository;
        public LoadPackagesCommand(IKernel kernel, MainWindowViewModel viewModel) 
            :base(kernel, viewModel)
        {
            _queryPackageRepository = _kernel.Get<IQueryPackageRepository>();
        }

        protected override async Task ExecuteAsync(object parameter)
        {
            _viewModel?.Packages.Clear();
            var packages = await _queryPackageRepository.GetPackagesAsync();
            foreach (var package in packages)
            {
                _viewModel.Packages.Add(package);
            }
        }
    }
}
