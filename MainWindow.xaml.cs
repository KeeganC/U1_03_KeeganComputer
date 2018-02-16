﻿/* Keegan Chan
 * Febuary 13 2018
 * U1_03_KeeganComputer
 * Displays details about a computer part and it's compatible computer parts
 * */
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

namespace U1_03_KeeganComputer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPage2_Click(object sender, RoutedEventArgs e)
        {
            txbPartName.Text = "AMD - Ryzen 5 1600 3.2GHz 6-Core Processor";
            txbLink1.Text = "https://www.amd.com/en/products/cpu/amd-ryzen-5-1600";
            txbPrice1.Text = "238.95$";
            BitmapImage bi = new BitmapImage(new Uri("https://c.76.my/Malaysia/amd-ryzen-5-1600-processor-3-6ghz-19mb-cache-am4-saveallstore-1704-17-F379278_1.jpg"));
            imgComPart.Source = bi;
        }

        private void btnPage3_Click(object sender, RoutedEventArgs e)
        {
            txbPartName.Text = "MSI - B350 PC MATE ATX AM4 Motherboard";
            txbLink1.Text = "https://www.msi.com/Motherboard/B350-PC-MATE.html";
            txbPrice1.Text = "109.00$";
            BitmapImage bi = new BitmapImage(new Uri("https://images-na.ssl-images-amazon.com/images/I/61LrNFyFJqL.jpg"));
            imgComPart.Source = bi;
        }

        private void btnPage1_Click(object sender, RoutedEventArgs e)
        {
            txbPartName.Text = "Corsair Vengeance C70 Mid-Tower Gaming Case";
            txbLink1.Text = "http://www.corsair.com/en-us/vengeance-c70-mid-tower-gaming-case-gunmetal-black";
            txbPrice1.Text = "159.99$";
            BitmapImage bi = new BitmapImage(new Uri("https://www.telemart.pk/media/catalog/product/cache/7/thumbnail/9df78eab33525d08d6e5fb8d27136e95/c/c/ccgreen.jpg"));
            imgComPart.Source = bi;
        }

        private void btnPage4_Click(object sender, RoutedEventArgs e)
        {
            txbPartName.Text = "Seagate - Barracuda 2TB 3.5 inches 7200RPM Internal Hard Drive";
            txbLink1.Text = "https://www.seagate.com/ca/en/internal-hard-drives/hdd/barracuda/";
            txbPrice1.Text = "69.49$";
            BitmapImage bi = new BitmapImage(new Uri("https://www.webantics.com/content/images/thumbs/007/0070614_seagate-barracuda-2tb-sata-iii-7200rpm-35-internal-hard-drive_600.jpeg"));
            imgComPart.Source = bi;
        }

        private void btnPage5_Click(object sender, RoutedEventArgs e)
        {
            txbPartName.Text = "G.Skill - Ripjaws V Series 8GB (2 x 4GB) DDR4-3000 Memory";
            txbLink1.Text = "https://www.newegg.com/Product/Product.aspx?Item=N82E16820231897";
            txbPrice1.Text = "132.99$";
            BitmapImage bi = new BitmapImage(new Uri("https://i.ebayimg.com/images/g/pdUAAOSwvR5aA1qA/s-l300.jpg"));
            imgComPart.Source = bi;
        }

        private void btnPage6_Click(object sender, RoutedEventArgs e)
        {
            txbPartName.Text = "Gigabyte - GeForce GTX 1050 2GB OC Video Card";
            txbLink1.Text = "https://www.gigabyte.com/Graphics-Card/GV-N1050OC-2GD#kf";
            txbPrice1.Text = "189.99$";
            BitmapImage bi = new BitmapImage(new Uri("https://static.gigabyte.com/Product/3/6063/20161017192855_big.png"));
            imgComPart.Source = bi;
        }

        private void btnPage7_Click(object sender, RoutedEventArgs e)
        {
            txbPartName.Text = "SeaSonic - 520W 80+ Bronze Certified Fully-Modular ATX Power Supply";
            txbLink1.Text = "https://www.newegg.ca/Product/Product.aspx?Item=N82E16817151093";
            txbPrice1.Text = "79.99$";
            BitmapImage bi = new BitmapImage(new Uri("https://images-na.ssl-images-amazon.com/images/I/71bZPEAdXIL._SY355_.jpg"));
            imgComPart.Source = bi;
        }
    }
}
