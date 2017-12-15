using System;
using System.Windows.Input;
using SigilTradeBot.ViewModel;

namespace SigilTradeBot.Commands
{
    class AuthenticateCommand : ICommand
    {
       public AuthenticateCommand(UserViewModel viewModel)
        {
            _viewModel = viewModel;
          
        }

        private UserViewModel _viewModel;
        
        
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {

            return true;

        }
        public void Execute(object parameter)
        {
            _viewModel.DefaultMarket.AuthenticateApi();
         

        }   
        
        
    }

}
