using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleWPFApp.Command
{
    public abstract class AsyncCommandBase : ICommand
    {
        protected bool _isExecuting;
        protected Action<Exception> _onException;

        public event EventHandler CanExecuteChanged;
        public bool IsExecuting
        {
            get => _isExecuting;
            set 
            {
                _isExecuting = value; 
                CanExecuteChanged?.Invoke(this, EventArgs.Empty); 
            }
        }

        public AsyncCommandBase(Action<Exception> onException)
        {
            _onException = onException;
        }        

        public virtual bool CanExecute(object parameter)
        {
            return !IsExecuting;
        }

        public async void Execute(object parameter)
        {
            IsExecuting = true;
            await ExecuteAsync(parameter);
            IsExecuting = false;
        }

        protected abstract Task ExecuteAsync(object parameter);
    }
}