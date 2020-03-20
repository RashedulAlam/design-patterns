using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.OpenClosedPrinciple
{
    public enum Color
    {
        Green,
        Red,
        Yellow,
    }

    public enum Size
    {
        Small,
        Medium, 
        Large,
        Huge,
    }

    public class Product
    {
        public Color Color { get; set; }
        public Size Size { get; set; }
        public string Name { get; set; }

        public Product(Color color, Size size, string name)
        {
            Color = color;
            Size = size;
            Name = name;
        }

    }

    public class ProductFilterOld
    {
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var product in products)
            {
                if (product.Size == size) 
                    yield return product;
            }
        }
    }
}