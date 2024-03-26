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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for Client1.xaml
    /// </summary>
    public partial class Client1 : Window
    {
        public Client1()
        {
            InitializeComponent();
        }

        private void Btn_PurchaseItm_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
            Items I1 = new Items();
            I1.ShowDialog();
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Image_Back(object sender, MouseButtonEventArgs e)
        {
            Close();
            MainWindow M1 = new MainWindow();
            M1.ShowDialog();

        }

        private void Image_Minimize(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn_AddItem_Click(object sender, RoutedEventArgs e)
        {

        }






        }
}
