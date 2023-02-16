using Ninject;
using SimpleWPFApp.ViewModel;

namespace SimpleWPFApp.Command
{
    public abstract class AsyncMainWindowCommandBase : AsyncCommandBase
    {

        protected IKernel _kernel;
        protected MainWindowViewModel _viewModel;
        protected AsyncMainWindowCommandBase(IKernel kernel, MainWindowViewModel viewModel)
            : base(viewModel.OnException) 
        {
            _kernel = kernel;
            _viewModel = viewModel;
        }
    }
}
