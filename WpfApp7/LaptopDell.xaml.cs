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
using System.Configuration;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for LaptopDell.xaml
    /// </summary>
    public partial class LaptopDell : Window
    {
        public LaptopDell()
        {
            InitializeComponent();
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Image_Back(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            Items I1 = new Items();
            I1.ShowDialog();
        }

    }
}
