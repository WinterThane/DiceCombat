using DiceCombat.Commands;
using DiceCombatGame.ViewModels;
using System.Windows.Input;

namespace DiceCombat
{
    public class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel selectedViewModel;

        public BaseViewModel SelectedViewModel
        {
            get { return selectedViewModel; }
            set 
            { 
                selectedViewModel = value; 
                OnPropertyChange(nameof(SelectedViewModel));
            }
        }

        public ICommand UpdateViewCommand { get; set; }

        public MainWindowViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }

    }
}
