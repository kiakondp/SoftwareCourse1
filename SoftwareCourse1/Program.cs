using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCourse1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<CatFood>();
            for (int i = 0; i < numberOfRecords; i++) 
            {
                var catFood = new CatFood();

                Console.WriteLine("Enter the product name: ");
                catFood.Name = Console.ReadLine();

                Console.WriteLine("Enter the price: ");
                catFood.Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter the quantity: ");
                catFood.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Is this for kittens? (true/false): ");
                catFood.IsKittenFood = bool.Parse(Console.ReadLine());

                recordList.Add(catFood);
            }
            Console.WriteLine("\nRecords:");
            foreach (var data in recordList) 
            {
                Console.WriteLine(data);
            }
        }
    }
}
