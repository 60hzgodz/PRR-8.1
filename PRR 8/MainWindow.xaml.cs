using System.Windows;
using System.Windows.Controls;

namespace PRR_8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void LoginTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Логин или почта")
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.White;
            }
        }
        private void LoginTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Логин или почта";
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }
        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            if (passwordBox.Password == "Пароль")
            {
                passwordBox.Password = "";
                passwordBox.Foreground = System.Windows.Media.Brushes.White;
            }
        }
        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            if (string.IsNullOrWhiteSpace(passwordBox.Password))
            {
                passwordBox.Password = "Пароль";
                passwordBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }
    }
}