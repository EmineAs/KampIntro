﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 5;

            Product product2 = new Product { id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 500, UnitsInStock = 5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //int, double,

        }


    }
}