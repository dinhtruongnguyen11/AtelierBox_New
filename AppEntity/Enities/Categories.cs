using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


public class Categories
{
    [Key]
    public int ID { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Decription { get; set; }
    public DateTime DateCreate { get; set; }
    public string UserCreate { get; set; }
    public string Active { get; set; }
    public string ImgSrc { get; set; }
}
