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
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Data.SqlClient;    // ADO.NET Class Library
using System.Configuration;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for CustomerSignUp.xaml
    /// </summary>
    public partial class CustomerSignUp : Window
    {
        public CustomerSignUp()
        {
            
            InitializeComponent();
            con = new SqlConnection("Data Source=DILSHAN;Initial Catalog=Technomart;Integrated Security=True");
            customerID();
        }



        // SqlConnection con; // Initiate The Pipeline
        SqlCommand cmd; // Initiate The Capsule
        SqlConnection con;


        void customerID()//Auto Generate Client ID
        {
            string getCustomerId = "select max(Customer_Id) AS Customer_Id from Customer";

            SqlCommand cmd1 = new SqlCommand(getCustomerId, con);
            con.Open();
            SqlDataReader dtr;  //Data reader
            dtr = cmd1.ExecuteReader();

            if (dtr.HasRows == true)
            {
                if (dtr.Read())
                {
                    string id = dtr["Customer_Id"].ToString();
                    int x1 = Int32.Parse(id.Replace("C", "").Trim());
                    x1 = x1 + 1;
                    txt_id.Text = "C" + x1;

                }
            }

            else // If it doesn't has raws
            {

            }


            con.Close();

        }

        private void Btn_Save_Click_1(object sender, RoutedEventArgs e)
        {
            if (txt_firstName.Text.Length == 0)
            {
                MessageBox.Show("First Name can not be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_firstName.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("First Name can not have numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_firstName.Text.Any(Char.IsPunctuation))
            {
                MessageBox.Show("First Name can not have punctuation marks", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_firstName.Text.Any(Char.IsSymbol))
            {
                MessageBox.Show("First Name can not have symbols", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_lastName.Text.Length == 0 || txt_lastName.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("Last Name can not be emty or can not have digits", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_lastName.Text.Any(Char.IsPunctuation) || txt_lastName.Text.Any(Char.IsSymbol))
            {
                MessageBox.Show("Last Name can not have punctuations and Symbols", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_email.Text.Length == 0)
            {
                MessageBox.Show("Email can not be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email.Ex:name@gmail.com", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (!Regex.IsMatch(txt_Password.Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
            {
                MessageBox.Show("Password must have at least 8 characters at least one uppercase letter one lowercase letter one digit and at least one special character", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (txt_ConfPassword.Password != txt_Password.Password)
            {
                MessageBox.Show(" Confirm password must be same as password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (txt_Address.Text.Length == 0)
            {
                MessageBox.Show("Address can not be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (txt_tp.Text.Length != 10 || txt_tp.Text.Any(char.IsLetter))
            {
                MessageBox.Show("TP must have 10 numbers and can not have letters", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_tp.Text.Any(char.IsSymbol))
            {
                MessageBox.Show("TP  can not have Symbols", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_tp.Text.Any(char.IsPunctuation))
            {
                MessageBox.Show("TP can not have any Punctuation", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("You have successfuly Registerd", "Info", MessageBoxButton.OK, MessageBoxImage.Information);


                con.Open();

                cmd = new SqlCommand("Insert into Customer values( '" + txt_id.Text + "','" + txt_firstName.Text + "','" + txt_lastName.Text + "', '" + txt_email.Text + "', '" + txt_Password.Password + "', '" + txt_ConfPassword.Password + "','" + txt_Address.Text + "', '" + txt_tp.Text + "')", con);

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MessageBox.Show("Data Save Successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                else
                    MessageBox.Show("Data Cannot Save", "Error", MessageBoxButton.OK, MessageBoxImage.Error);



                con.Close();

                CustomerLogin cl = new CustomerLogin();
                cl.ShowDialog();
            }

        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Image_Back(object sender, MouseButtonEventArgs e)
        {
            Login l1 = new Login();
            l1.ShowDialog();

        }

        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_email.Clear();
            txt_Password.Clear();
            txt_ConfPassword.Clear();
            txt_Address.Clear();
            txt_tp.Clear();
        }
    }
}
