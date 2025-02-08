// Author:  Gauge Garcia
// Course:  COMP-003A
// Faculty: Johnathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collect ion.



using System;

namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice=0;
            Console.Write("Welcome to the Inventory Managemnet System!");            
            string[] productNames = new string[10];
            int[] productQuantities = new int[10];
            string name;

                int i = 0;

            while (choice != 4)
            {
                Console.Write("Inventory Management system Menu\n" +
                              "1. Add a product \n" +
                              "2. Update Product Quantity \n" +
                              "3. View Inventory Summary\n" +
                              "4. Exit\n" +
                              "Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (i > 10)
                        {
                            Console.WriteLine("Too Many Items Added!");
                            break;
                        }
                        else
                            Console.WriteLine("Enter Product Name:");
                            productNames[i] = Console.ReadLine();
                            Console.WriteLine("Enter Product Quantity");
                            productQuantities[i] = int.Parse(Console.ReadLine());
                            i++;
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the product you wish to change:");
                        name = Console.ReadLine();
                        int ic = Array.IndexOf(productNames, name);
                        Console.WriteLine("Enter new product quantity:");
                        productQuantities[ic] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quantity Updated");
                        break;
                    case 3:
                        Console.WriteLine("Inventory Summary:");
                        for (ic = 0; ic < i; ic++)
                        {
                            Console.WriteLine($"- {productNames[ic]}: {productQuantities[ic]}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        break;
                }



            }
                       
        }
    }
}
