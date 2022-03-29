using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DiceCombatGame.Views;

namespace DiceCombat
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();
        }

        private void LoadGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddMonster_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitGame_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                var result = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
