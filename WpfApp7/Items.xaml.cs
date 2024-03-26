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
    /// Interaction logic for Items.xaml
    /// </summary>
    public partial class Items : Window
    {
        public Items()
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
            Client1 CL2 = new Client1();
            CL2.ShowDialog();
        }
        private void Btn_Asus_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Laptop l1 = new Laptop();
            l1.ShowDialog();
        }

        private void Btn_DELL_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LaptopDell l2 = new LaptopDell();
            l2.ShowDialog(); 

        }

        private void Btn_HP_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LaptopHp l3 = new LaptopHp();
            l3.ShowDialog();

        }

        private void Btn_Lenvo_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Laptop_Lenvo l4 = new Laptop_Lenvo();
            l4.ShowDialog();
        }

        private void Btn_LaptopBattery_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Laptop_battery lb = new Laptop_battery();
            lb.ShowDialog();
        }

        private void Btn_Printer_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Printer p = new Printer();
            p.ShowDialog();
        }

        private void Btn_Catridge_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Cartridge ca = new Cartridge();
            ca.ShowDialog();
        }

        private void Btn_Casing_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Casing cas = new Casing();
            cas.ShowDialog();
        }

        private void Btn_PowerSuply_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Power_Supply ps = new Power_Supply();
            ps.ShowDialog();
        }

        private void Btn_CPU_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Cpu cu1 = new Cpu();
            cu1.ShowDialog();
        }

        private void Btn_Cooler_Heat_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Cpucooler_and_heatsink ch = new Cpucooler_and_heatsink();
            ch.ShowDialog();
        }
    }
}
