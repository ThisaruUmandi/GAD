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
using System.Text.RegularExpressions;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for CustomerLoginw.xaml
    /// </summary>
    public partial class CustomerLogin : Window
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void Btn_SignUp_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CustomerSignUp cu1 = new CustomerSignUp();
            cu1.ShowDialog();
            

        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Image_Minimize(object sender, MouseButtonEventArgs e)
        {

        }


        private void Image_Back(object sender, MouseButtonEventArgs e)
        {
            Hide();
            MainWindow m1 = new MainWindow();
            m1.ShowDialog();

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

                else if (txt_Password.Password.Length == 0)
                {
                    MessageBox.Show("Password can not be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (!Regex.IsMatch(txt_Password.Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
                {
                    MessageBox.Show("Password must have at least 8 characters, at least one uppercase letter, one lowercase letter, one digit and at least one special character", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else
                {
                    
                    Items I1 = new Items();
                    Close();
                    I1.ShowDialog();

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            View v1 = new View();
            v1.ShowDialog();

        }
    }
}
