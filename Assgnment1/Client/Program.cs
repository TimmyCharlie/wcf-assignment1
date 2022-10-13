using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            Boolean end = false;
            int userOption;

            while (!end)
            {
                Console.WriteLine("");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("");
                Console.WriteLine("1. Prime Number");
                Console.WriteLine("2. Sum of Digits");
                Console.WriteLine("3. Reverse a String");
                Console.WriteLine("4. Pring HTML tags");
                Console.WriteLine("5. Sort 5 Numbers");
                Console.WriteLine("0. Exit");
                Console.WriteLine("");

                userOption = int.Parse(Console.ReadLine());

                switch (userOption)
                {
                    case 0:
                        end = true;
                        break;
                    case 1:
                        int n;
                        Console.WriteLine("Please a integer");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine(client.Prime(n));
           
                        break;
                    case 2:
                        int n1;
                        Console.Write("Enter a number to sum: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("The sum is " + client.SumDigit(n1));
                        break;

                        case 3:
                        Console.Write("Enter a string to revert: ");
                        string str = Console.ReadLine();
                        Console.WriteLine("Reversed string: " + client.ReverseString(str));
                        break;
                    case 4:
                        string tag, data;
                        Console.WriteLine("Enter the tag");
                        tag = Console.ReadLine();
                        Console.WriteLine("Enter the data");
                        data = Console.ReadLine();
                        Console.WriteLine(client.PrintHtml(tag,data));
                        break;

                    case 5:
                        int order;
                        int[] ints = new int[5];

                        Console.WriteLine("Please chose one of the orders");
                        Console.WriteLine("1. Ascending");
                        Console.WriteLine("2. Descending");
                        order = int.Parse(Console.ReadLine());


                        Console.WriteLine("Please enter 5 numbers, 1 per line");
                        for (int counter = 0; counter < 5; counter++)
                        {
                            ints[counter] = int.Parse(Console.ReadLine());
                        }

                        ints = client.Sort5(ints, order);
                        Console.WriteLine("The numbers are " + ints[0] + ints[1] + ints[2] + ints[3] + ints[4]);

                        break;
                }
            }


        }
    }
}
