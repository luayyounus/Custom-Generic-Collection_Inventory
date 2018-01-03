using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceStore.Classes
{
    public class Product
    {
        public string Name { get; set; }
        public ProductType Type { get; set; }

        public Product(string name, ProductType type)
        {
            Name = name;
            Type = type;
        }
    }
}
