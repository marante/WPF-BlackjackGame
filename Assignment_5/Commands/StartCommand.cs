using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Assignment_5.ViewModels;

namespace Assignment_5.Commands
{
    public class StartCommand : ICommand
    {

        private readonly StartViewModel _startViewModel;

        public StartCommand(StartViewModel model)
        {
            _startViewModel = model;
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            if (!string.IsNullOrWhiteSpace(_startViewModel.Name) && _startViewModel.Money > 0)
            {
                return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            _startViewModel.StartGame();
        }
    }
}
