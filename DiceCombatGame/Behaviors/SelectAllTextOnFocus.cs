using System.Windows;
using System.Windows.Controls;

namespace DiceCombatGame.Behaviors
{
    public static class SelectAllTextOnFocus
    {
        //made by arbenowskee from Kauč Utrdba on Discord
        public static readonly DependencyProperty IsEnabledProperty = 
            DependencyProperty.RegisterAttached("IsEnabled", 
                typeof(bool), 
                typeof(SelectAllTextOnFocus), 
                new PropertyMetadata(false, OnSelectedAllPropertyChange));

        public static bool GetIsEnabled(Control control)
        {
            return (bool)control.GetValue(IsEnabledProperty);
        }

        public static void SetIsEnabled(Control control, bool value)
        {
            control.SetValue(IsEnabledProperty, value);
        }

        private static void OnSelectedAllPropertyChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not TextBox textBox)
            {
                return;
            }

            if (e.NewValue is true)
            {
                textBox.GotFocus += TextBoxOnGotFocus;
            }
            else
            {
                textBox.GotFocus -= TextBoxOnGotFocus;
            }
        }

        private static void TextBoxOnGotFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox)?.SelectAll();
        }
    }
}
