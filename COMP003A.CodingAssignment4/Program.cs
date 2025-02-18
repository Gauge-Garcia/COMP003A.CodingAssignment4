// Author:  Gauge Garcia
// Course:  COMP-003A
// Faculty: Johnathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collect ion.



using System;
using System.ComponentModel.Design;

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
            string name=" ";
            int quantity;

            int i = 0;
            int ic = 0;
                    
            while (choice != 4)
            {
                Console.Write("Inventory Management system Menu\n" +
                              "1. Add a product \n" +
                              "2. Update Product Quantity \n" +
                              "3. View Inventory Summary\n" +
                              "4. Exit\n"); 
                 
                Console.WriteLine("Enter your choice: ");
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
                            try
                            {
                                Console.WriteLine("Enter Product Name:");
                                productNames[i] = Console.ReadLine();
                                Console.WriteLine("Enter Product Quantity");
                                productQuantities[i] = int.Parse(Console.ReadLine());
                                i++;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid Input, Please try again.");
                            }
                    break;
                    case 2:
                        ic = -1;
                        try
                        {

                            Console.WriteLine("Enter the name of the product you wish to change:");
                            name = Console.ReadLine();
                            ic = Array.IndexOf(productNames, name);
                            if (ic != -1 && ic <= i)
                            {
                                Console.WriteLine("Enter new product quantity:");
                                productQuantities[ic] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Quantity Updated");
                            }
                            else
                            {
                                Console.WriteLine("Product not found, try again please.");
                            }
                        }

                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid Input!");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Inventory Summary:");
                        for (ic = 0; ic < i; ic++)
                        {
                            name = productNames[ic];
                            quantity = productQuantities[ic];
                            InventorySummary(name, quantity);
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
        static void InventorySummary(string productnames, int productquantities)
        {
            Console.WriteLine($"- {productnames}: {productquantities}");
        }
    }
}
