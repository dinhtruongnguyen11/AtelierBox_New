<<<<<<< HEAD
﻿using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace AppMain
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public static Product p;
        public static CartProduct cartProduct;
        public DispatcherTimer timer;
        
        public DetailWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();

            p = new Product
            {
                Active = "Active",
                CatCode = 1,
                DateCreate = DateTime.Now,
                Description = "Noni juice is a globally popular health beverage originating in the tropics. Traditional Tahitian healers believe the noni plant to be useful for a wide range of maladies, and noni juice consumers throughout the world have similar perceptions. Nevertheless, human clinical trials are necessary for a precise understanding of what the health benefits of noni juice are. A review of published human intervention studies suggests that noni juice may provide protection against tobacco smoke-induced DNA damage, blood lipid and homocysteine elevation as well as systemic inflammation. Human intervention studies also indicate that noni juice may improve joint health, increase physical endurance, increase immune activity, inhibit glycation of proteins, aid weight management, help maintain bone health in women, help maintain normal blood pressure, and improve gum health. Further, these studies point to notable antioxidant activity in noni juice, more so than other fruit juices which served as trial placebos. It is this antioxidant effect and its interaction with the immune system and inflammation pathways that may account for many of the observed health benefits of noni juice. However, the existing evidence does have some limitations as far as its general application to noni juice products; all the peer-reviewed human interventions studies to date have involved only one source of French Polynesian noni juice. Geographical factors and variations in processing methods are known to produce commercial noni juice products with divergent phytochemical and nutrient compositions. Therefore, other sources of noni products may have different toxicological and pharmacological profiles.",
                ID = 1,
                ImgSrc = "bottle.png",
                Instock = 10,
                Name = "Tree of health noni juice".ToUpper(),
                Price = 19.15,
                UserCreate = "Admin"
            };

            cartProduct = new CartProduct
            {
                ID = 1,
                Name = "Tree of health noni juice".ToUpper(),
                Price = 19.15,
                Quantity = 0
            }; 

            gridDetail.DataContext = p;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            string dateFormat = now.ToString("dd-MM-yyyy");
            tbDate.Text = $"{now.DayOfWeek}\n{dateFormat}";
            //tbTime.Text = $"{now.Hour}:{now.Minute}";
            tbTime.Text = $"{now.ToString("HH:mm")}";
        }

        public DetailWindow(Product _product, ref CartProduct _cart)
        {
            InitializeComponent();
            p = _product;
            cartProduct = _cart;
            gridDetail.DataContext = p;

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
            p1.Price = 100;
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //New cart
            cartProduct.Quantity = int.Parse(txtQuantity.Text);
            //Send back cart
            //this.DialogResult = true;
            this.Close();
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
=======
﻿using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace AppMain
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public static Product p;
        public static CartProduct cartProduct;
        public DispatcherTimer timer;
        
        public DetailWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();

            p = new Product
            {
                Active = "Active",
                CatCode = 1,
                DateCreate = DateTime.Now,
                Description = "Noni juice is a globally popular health beverage originating in the tropics. Traditional Tahitian healers believe the noni plant to be useful for a wide range of maladies, and noni juice consumers throughout the world have similar perceptions. Nevertheless, human clinical trials are necessary for a precise understanding of what the health benefits of noni juice are. A review of published human intervention studies suggests that noni juice may provide protection against tobacco smoke-induced DNA damage, blood lipid and homocysteine elevation as well as systemic inflammation. Human intervention studies also indicate that noni juice may improve joint health, increase physical endurance, increase immune activity, inhibit glycation of proteins, aid weight management, help maintain bone health in women, help maintain normal blood pressure, and improve gum health. Further, these studies point to notable antioxidant activity in noni juice, more so than other fruit juices which served as trial placebos. It is this antioxidant effect and its interaction with the immune system and inflammation pathways that may account for many of the observed health benefits of noni juice. However, the existing evidence does have some limitations as far as its general application to noni juice products; all the peer-reviewed human interventions studies to date have involved only one source of French Polynesian noni juice. Geographical factors and variations in processing methods are known to produce commercial noni juice products with divergent phytochemical and nutrient compositions. Therefore, other sources of noni products may have different toxicological and pharmacological profiles.",
                ID = 1,
                ImgSrc = "bottle.png",
                Instock = 10,
                Name = "Tree of health noni juice".ToUpper(),
                Price = 19.15,
                UserCreate = "Admin"
            };

            cartProduct = new CartProduct
            {
                ID = 1,
                Name = "Tree of health noni juice".ToUpper(),
                Price = 19.15,
                Quantity = 0
            }; 

            gridDetail.DataContext = p;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            string dateFormat = now.ToString("dd-MM-yyyy");
            tbDate.Text = $"{now.DayOfWeek}\n{dateFormat}";
            //tbTime.Text = $"{now.Hour}:{now.Minute}";
            tbTime.Text = $"{now.ToString("HH:mm")}";
        }

        public DetailWindow(Product _product, ref CartProduct _cart)
        {
            InitializeComponent();
            p = _product;
            cartProduct = _cart;
            gridDetail.DataContext = p;

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
            cartProduct.Quantity = int.Parse(txtQuantity.Text);
            //Send back cart
            //this.DialogResult = true;
            this.Close();
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
>>>>>>> dinhnt
