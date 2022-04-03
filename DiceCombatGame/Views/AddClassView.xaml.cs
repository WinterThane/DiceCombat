using DiceCombatGame.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace DiceCombatGame.Views
{
    /// <summary>
    /// Interaction logic for AddClassView.xaml
    /// </summary>
    public partial class AddClassView : UserControl
    {
        AddClassViewModel viewModel;

        public AddClassView()
        {
            InitializeComponent();
            viewModel = new AddClassViewModel();
            classesLV.ItemsSource = viewModel.PlayerClassesList;
            DataContext = viewModel;
        }

        private void SaveClass_Click(object sender, RoutedEventArgs e)
        {
            viewModel.SaveClass();
            ClassAddedText.Visibility = Visibility.Visible;
        }

        private void ClassNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            ClassAddedText.Visibility=Visibility.Hidden;
        }

        private void SelectAllText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Dispatcher.BeginInvoke(new Action(() => textBox.SelectAll()));
        }
    }
}
