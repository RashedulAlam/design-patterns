using System;
using System.Collections.Generic;
using System.Diagnostics;
using Design_Patterns.OpenClosedPrinciple;
using Design_Patterns.SingleResponsibility;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////single responsibility example ////////
                // var journal = new Journal();
                // journal.AddEntry("My first Journal");
                // journal.AddEntry("My second Journal");
                // var persistence = new Persistence();
                // persistence.WriteAllText(journal, @"D:\1.txt");
                // Process.Start(@"cmd.exe",@"D:\1.txt");
            /////////////OPen Closed example ///////////////
            
            var productList = new List<Product>()
            {
                new Product(Color.Green, Size.Huge, "Apple"),
                new Product(Color.Red, Size.Large, "Jackfruit"),
                new Product(Color.Yellow, Size.Small, "Berry"),
                new Product(Color.Green, Size.Medium, "Durian"),
            };

            var productFilter = new ProductFilter();

            foreach (var product in productFilter.Filter(productList, new AndSpecification<Product>(
                new ColorSpecification(Color.Red), new ColorSpecification(Color.Red)
                )))
            {
                Console.WriteLine($"item - {product.Name}");
            }

            Console.WriteLine();
        }
    }
}
