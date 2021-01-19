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
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    /// 

    public partial class HomeScreen : Window
    {
        public List<BlockUI> BlockProductUIs { get; set; }
        private DbAppContext dbAppContext;
        public HomeScreen()
        {
            InitializeComponent();
            dbAppContext = DBHelper.CreateConnection();
            LoadProduct();
        }
        public void LoadProduct(bool isRetireve = true)
        {

            List<Product> listProduct = dbAppContext.Products.ToList().OrderBy(x => x.ID).ToList(); ;
            List<BlockUI> BlockUIs = new List<BlockUI>();

            int i = 0;
            BlockUIs = (from lp in listProduct
                        group lp by i++ % 2 into ll
                        select new BlockUI { block_id = ll.Key, ProductUIs = ll.ToList() }).ToList();

            BlockProductUIs = BlockUIs;

            // Bidding data to XAML
            this.DataContext = this;
        }
    }
}
