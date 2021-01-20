using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AppMain
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public Product p;
        public DetailWindow()
        {
            InitializeComponent();
            p = new Product { Price = 19.15, Instock = 10 };
        }
        public DetailWindow(Product _product)
        {
            InitializeComponent();
            p = _product;
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            int quantity = int.Parse(txtQuantity.Text);
            
            if (quantity + 1 > p.Instock)//Số lượng lớn hơn stock
            {
                return;
                //MessageBox.Show("Số lượng có hạn", "Hết hàng", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            txtQuantity.Text = (quantity + 1).ToString();

            //Kiểm tra tiếp nếu Số lượng lớn hơn stock thì disable
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            int quantity = int.Parse(txtQuantity.Text);
            if (quantity - 1 != 0)
            {
                txtQuantity.Text = (quantity - 1).ToString();
            }
            //Enable nut add

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //New cart
            //Add cart
            //Cancel
        }

        private void txtQuantity_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]").IsMatch(e.Text);
        }

        private void txtQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (p == null)
            {
                p = new Product { Price = 19.15, Instock = 10 };
            }

            int quantity = int.Parse(txtQuantity.Text);

            if(txtTotal != null)
            {
                txtTotal.Text = "$" + Math.Round(quantity * p.Price, 2).ToString("#00.00");
            }    

        }
    }
}
