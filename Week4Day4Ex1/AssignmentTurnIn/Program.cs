using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Day4Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            char yes = 'y';
            while (yes == 'y')
            {
                Console.WriteLine("\t |{WELCOME TO HUNG'S TESTING ROOM}|");
                Console.WriteLine("\t ----------------------------------");
                Console.WriteLine("\t Lets get started!");
                Console.WriteLine("\t What would you like to do?");
                Console.WriteLine("\t ----------------------------------");
                Console.WriteLine("\t 1. Create a 2D Array");
                Console.WriteLine("\t 2. Create a JaggedArray");
                Console.WriteLine("\t 3. Test an overloaded method through + and * ");
                Console.WriteLine("\t 4. Test operators within a class ");
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Arrays.array2D();
                        Console.ReadLine();
                        break;
                    case 2:
                        Arrays.jaggedArray();
                        Console.ReadLine();
                        break;
                    case 3:
                        Overload.overloadFlows();
                        Console.ReadLine();
                        break;
                    case 4:
                        Circle.circleCase();
                        Console.ReadLine();
                        break;
                    default:
                        {
                            Console.WriteLine("\t You entered the wrong number of sequence");
                            break;
                        }
                }
                Console.WriteLine("\t ---------------------------------------------------");
                Console.WriteLine("\t Would you like to continue testing different cases?");
                Console.WriteLine("\t Press 'Y' for Yes and 'N' for No");
                yes = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\t ---------------------------------------------------");
            }
            Console.WriteLine("\t -----------------------------------------------------");
            Console.WriteLine("\t Program is closing...");
            Console.WriteLine("\t Press enter 2x to close the program");
            Console.ReadLine();
            Console.WriteLine("\t -----------------------------------------------------");
        }

    }
}
