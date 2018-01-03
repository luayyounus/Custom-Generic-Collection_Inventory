using System;
using System.Collections.Generic;
using System.Linq;
using EcommerceStore.Classes;

namespace EcommerceStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Chocolate", ProductType.Grocery);
            Product product2 = new Product("Apple", ProductType.Grocery);
            Product product3 = new Product("Milk", ProductType.Grocery);
            Product product4 = new Product("Banana", ProductType.Grocery);
            Product product5 = new Product("JAWS", ProductType.Movies);
            Product product6 = new Product("Titanic", ProductType.Movies);
            Product product7 = new Product("Star Wars", ProductType.Movies);
            Product product8 = new Product("Batman", ProductType.Movies);
            Product product9 = new Product("Tooth Paste", ProductType.Health);
            Product product10 = new Product("Band Aids", ProductType.Health);

            List<Product> productsList = new List<Product>
            {
                product1, product2, product3, product4, product5, product6, product7, product8, product9, product10
            };

            Console.WriteLine("\n    Using List Add Method");
            Console.WriteLine("------------------------------------------------------------------------");

            // Adding 10 Items with List.Add
            Console.WriteLine("\n Adding 10 items to Inventory");
            ViewAllProducts(productsList);

            // Removing Health Products with List.Remove
            Console.WriteLine("\n    Removing Health Products");
            productsList.Remove(product9);
            productsList.Remove(product10);
            ViewAllProducts(productsList);

            Inventory<Product> inventory = new Inventory<Product>();

            Console.WriteLine("\n    Using Inventory Add, Remove, AtIndex methods");
            Console.WriteLine("------------------------------------------------------------------------");

            // Adding 10 Items with Inventory.Add
            Console.WriteLine("\n Adding 10 items to Inventory");
            inventory.Add(product1); inventory.Add(product2); inventory.Add(product3); inventory.Add(product4); inventory.Add(product5);
            inventory.Add(product6); inventory.Add(product7); inventory.Add(product8); inventory.Add(product9); inventory.Add(product10);
            ViewAllProducts(inventory.Items.OfType<Product>().ToList());

            // Removing Health Products with Inventory.Remove
            Console.WriteLine("\n    Removing Health Products");
            inventory.Remove(product9);
            inventory.Remove(product10);
            ViewAllProducts(inventory.Items.OfType<Product>().ToList());

            // Finding Batman Index
            Console.WriteLine("\n    Getting Index of Batman Movie");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("     The index is: {0}", inventory.AtIndexOf(product8));

            Console.ReadLine();
        }

        public static void ViewAllProducts(List<Product> products)
        {
            Console.WriteLine("-------------------------------");
            foreach (Product p in products)
            {
                Console.WriteLine("    " + p.Name + " - " + p.Type);
            }
        }
    }
}
