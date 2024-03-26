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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Image_Back(object sender, MouseButtonEventArgs e)
        {
            Hide();
            MainWindow m1 = new MainWindow();
            m1.ShowDialog();

        }
        private void Btn_SignUp_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Display D1 = new Display();
            D1.ShowDialog();

        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Image_Minimize(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn_SignIn_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Btn_SignIn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_UserName.Text.Length == 0)
                {
                    MessageBox.Show("User name can not be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else if (txt_UserName.Text.Any(Char.IsPunctuation))

                {
                    MessageBox.Show("User name can not have any punctuation marks", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (txt_UserName.Text.Any(Char.IsSymbol))
                {
                    MessageBox.Show("You can not use symbols for user name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else if (txt_Password.Password.Length <= 6)
                {
                    MessageBox.Show("Your password is incorrect and can not havs less than six numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (txt_Password.Password.Length == 0)
                {
                    MessageBox.Show("Password can not be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Client1 Cl1 = new Client1();
                    Cl1.ShowDialog();

                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter words only", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Something is wrong please check again ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
