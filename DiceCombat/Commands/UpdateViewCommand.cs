using DiceCombatGame.ViewModels;
using System;
using System.Windows.Input;

namespace DiceCombat.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainWindowViewModel viewModel;

        public UpdateViewCommand(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter != null)
            {
                if (parameter.ToString() == "NewGame")
                {
                    viewModel.SelectedViewModel = new NewGameViewModel();
                }
                else if (parameter.ToString() == "AddClass")
                {
                    viewModel.SelectedViewModel = new AddClassViewModel();
                }
            }
            
        }
    }
}
