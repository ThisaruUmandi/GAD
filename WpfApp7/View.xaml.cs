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
using System.Data;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : Window
    {
        public View()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DILSHAN;Initial Catalog=Technomart;Integrated Security=True");
        }

        SqlConnection con;
        SqlDataAdapter da;

       

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select * from Client", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
           
            con.Close();
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Image_Back(object sender, MouseButtonEventArgs e)
        {
            MainWindow mw1 = new MainWindow();
            Close();
            mw1.ShowDialog();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
