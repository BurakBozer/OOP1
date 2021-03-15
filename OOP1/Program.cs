using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.CategoryId = 11;
            product1.ProductName = "Masa";
            product1.UnitPrice = 25;
            product1.UnitsInStock = 70;

            Product product2 = new Product { Id = 2 , CategoryId = 22 , ProductName = "Sandalye", UnitPrice = 35 , UnitsInStock = 90};

            Product product3 = new Product();
            product3.Id = 3;
            product3.CategoryId = 33;
            product3.ProductName = "Televizyon";
            product3.UnitPrice = 1000;
            product3.UnitsInStock = 120;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Remove(product2);
            productManager.Update(product3);
        }
    }
}
