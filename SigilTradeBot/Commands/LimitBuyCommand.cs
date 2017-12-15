using System;
using System.Windows.Input;
using SigilTradeBot.ViewModel;

namespace SigilTradeBot.Commands
{
    class LimitBuyCommand : ICommand
    {
       public LimitBuyCommand(UserViewModel viewModel)
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
        public async void Execute(object parameter)
        {
            await _viewModel.DefaultMarket.PlaceBuyOrder();
         

        }   
        
        
    }

}
