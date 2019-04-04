using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExportPDF.Models
{
    public class ProductModel
    {
        public List<Product> findAll()
        {
            List<Product> result = new List<Product>();
            result.Add(new Product { Id = "p01", Name = "Product 1", Price = 100, Photo = "1.PNG" });
            result.Add(new Product { Id = "p02", Name = "Product 2", Price = 200, Photo = "2.JPG" });
            return result;
        }
    }
}