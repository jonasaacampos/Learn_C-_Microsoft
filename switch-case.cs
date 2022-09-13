using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SKU = Stock Keeping Unit
            string sku = "01-MN-L";

            string[] product = sku.Split('-');
            string type = product[0];
            string color = product[1];
            string size = product[2];

            switch (type)
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;

            }

            switch (color)
            {
                case "MN":
                    color = "Maroon";
                    break; 
                case "BL":
                    color = "Black";
                    break;
                default:
                    color = "White";
                    break;
            }

            switch (size)
            {
                case "S":
                    size = "small";
                    break;
                case "M":
                    size = "medium";
                    break;
                case "L":
                    size = "large";
                    break;
                default:
                    size = "unique";
                    break;
            }

            Console.WriteLine($"Product: {type}" +
                              $"\nColor: {color}\n" +
                              $"Size: {size}");
        }
    }
}
