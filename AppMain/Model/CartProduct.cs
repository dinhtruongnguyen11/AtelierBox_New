using System;
using System.Collections.Generic;
using System.Text;


public class CartProduct
{
    private int iD;
    private string name;
    private int quantity;
    private float price;

    public int ID { get => iD; set => iD = value; }
    public string Name { get => name; set => name = value; }
    public int Quantity { get => quantity; set => quantity = value; }
    public float Price { get => price; set => price = value; }
}
