using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cart
{
    private double total;
    private List<CartProduct> listCardProduct;

    public double Total { get => total; set => total = value; }
    public List<CartProduct> ListCardProduct { get => listCardProduct; set => listCardProduct = value; }
}
