using AppConnection.Connection;
using AppMain.AppCode;
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

namespace AppMain
{
    /// <summary>
    /// Interaction logic for ProductScreen.xaml
    /// </summary>
    public partial class ProductScreen : Window
    {
        DbAppContext dbAppContext;
        public List<Categories> BlockCategoryUIs { get; set; }
        public List<BlockUI> BlockProductUIs { get; set; }
        public List<CartProduct> BlockCartProducts { get; set; }



        public ProductScreen()
        {
            InitializeComponent();
            dbAppContext = DBHelper.CreateConnection();
            List<Categories> categories = new List<Categories> { new Categories { Name="HYGIENE",Width=170,Height=250}
                                                               , new Categories { Name = "DRINKS AND SNACKS" ,Width=220,Height=300}
                                                               , new Categories { Name = "HEALTHY FOOD",Width=170,Height=250 } };
            //dbAppContext.Categories.AddRange(categories);
            //dbAppContext.SaveChanges();
            //var a = dbAppContext.Categories.ToList();
            BlockCategoryUIs = categories;


            List<Product> listProduct = new List<Product> {
                new Product { Name = "BOTTLED DRINK WATER1" },
                new Product { Name = "BOTTLED DRINK WATER2" },
                new Product { Name = "BOTTLED DRINK WATER3" },
                new Product { Name = "BOTTLED DRINK WATER4" },
                new Product { Name = "BOTTLED DRINK WATER5" },
                new Product { Name = "BOTTLED DRINK WATER6" },
                new Product { Name = "BOTTLED DRINK WATER7" },
                new Product { Name = "BOTTLED DRINK WATER8" },
                new Product { Name = "BOTTLED DRINK WATER9" },
                new Product { Name = "BOTTLED DRINK WATER10" },
                new Product { Name = "BOTTLED DRINK WATER11" },
                new Product { Name = "BOTTLED DRINK WATER12" },
            };

            int i = 0;
            BlockProductUIs = (from lp in listProduct
                        group lp by i++ % 3 into ll
                        select new BlockUI { block_id = ll.Key, ProductUIs = ll.ToList() }).ToList();

            

            List<CartProduct> listCart = new List<CartProduct> {
                new CartProduct { Name = "BOTTLED DRINK WATER1" },
                new CartProduct { Name = "BOTTLED DRINK WATER2" },
                new CartProduct { Name = "BOTTLED DRINK WATER3" },
                new CartProduct { Name = "BOTTLED DRINK WATER4" },
                new CartProduct { Name = "BOTTLED DRINK WATER5" },
                new CartProduct { Name = "BOTTLED DRINK WATER6" }
            };

            BlockCartProducts = listCart;


            this.DataContext = this;

        }

    }
}
