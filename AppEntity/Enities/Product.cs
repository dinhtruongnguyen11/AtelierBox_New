using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

public class Product 
{   
    [Key]
    public int ID { get; set; }
    public int CatCode { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateCreate { get; set; }
    public string UserCreate { get; set; }
    public string Active { get; set; }
    public int Instock { get; set; }
    public double Price { get; set; }
    public string ImgSrc { get; set; }

}


