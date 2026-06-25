using System.Windows;
using System.Windows.Controls;

namespace PRR_8
{
    public partial class Password : Window
    {
        public Password()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        
        private void CodeTextBox_GetFocus(object sender, RoutedEventArgs e)  
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Код из почты")
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void CodeTextBox_LostFocus(object sender, RoutedEventArgs e)  
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Код из почты";
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

    }
}