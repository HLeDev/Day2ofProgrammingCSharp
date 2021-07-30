using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Day4Ex1
{
    class Overload
    {
        public static void overloadFlows()
        {
            char yes = 'y';
            while (yes == 'y')
            {
                Console.WriteLine("\t Lets do some calculation!!!!");
                Console.WriteLine("\t What would you like to do?");
                Console.WriteLine("\t ----------------------------");
                Console.WriteLine("\t 1.  Add two numbers");
                Console.WriteLine("\t 2.  Add three numbers");
                Console.WriteLine("\t 3.  Multiply two numbers");
                Console.WriteLine("\t 4.  Multiple three numbers");

                int choice;

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        int a, b, c;
                        int addResult;
                        Console.WriteLine("\t Lets add two numbers!");
                        Console.WriteLine("\t ---------------------");
                        Console.WriteLine("\t Please enter the first number");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Please enter the second number");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine("\t -------------------------------");
                        Console.WriteLine("\t Now, lets add these three numbers...");
                        addResult = Add(a, b);
                        Console.WriteLine($"\t The answer is...\n \t [ {a} + {b} ] = | {addResult} |");
                        break;
                    case 2:
                        Console.WriteLine("\t Lets add three numbers!");
                        Console.WriteLine("\t -----------------------");
                        Console.WriteLine("\t Please enter the first number");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\t Please enter the second number");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\t Please enter the third number");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine("\t -------------------------------");
                        Console.WriteLine("\t Now, lets add these three numbers...");
                        addResult = Add(a, b, c);
                        Console.WriteLine($"\t The answer is...\n \t [ {a} + {b} + {c} ] =  | {addResult} |");
                        break;
                    case 3:
                        float i, j, k;
                        float multResult;
                        Console.WriteLine("\t Lets multiply two numbers!");
                        Console.WriteLine("\t --------------------------");
                        Console.WriteLine("\t Please enter the first number");
                        i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\t Please  enter the second number");
                        j = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine("\t -------------------------------");
                        Console.WriteLine("\t Now, lets multiply these two numbers...");
                        multResult = Multiply(i, j);
                        Console.WriteLine($"\t The answer is...\n \t [ {i} + {j} ] = | {multResult} |");
                        break;
                    case 4:
                        Console.WriteLine("\t Lets multiply three numbers!");
                        Console.WriteLine("\t ----------------------------");
                        Console.WriteLine("\t Please enter the first number");
                        i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\t Please enter the second number");
                        j = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\t Please enter the third number");
                        k = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine("\t -------------------------------");
                        Console.WriteLine("\t Now, lets multiply these three numbers...");
                        multResult = Multiply(i, j, k);
                        Console.WriteLine($"\t The answer is...\n \t [ {i} * {j} * {k} ] = | {multResult} |");
                        break;
                    default:
                        {
                            Console.WriteLine("\t You inputted an inccorect number of sequence");
                            break;
                        }
                }
                Console.WriteLine("\t -----------------------------------------------------");
                Console.WriteLine("\t Would you like to continue with the overload methods?");
                Console.WriteLine("\t Press 'Y' for yes and 'N' for No");
                yes = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\t -----------------------------------------------------");
            }
            Console.WriteLine("\t Lets go back to the previous menu...");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static float Multiply(float a, float b)
        {
            return a * b;
        }
        static float Multiply(float a, float b, float c)
        {
            return a * b * c;
        }
    }
}
class Circle //Operator
{
    public static void circleCase()
    {
        char yes = 'y';
        while (yes == 'y')
        {
            Console.WriteLine("\t Lets calculate some circle!!");
            Console.WriteLine("\t We'll be adding and subtracting circle for this exercise");
            Console.WriteLine("\t Before we can add or subtract any circle, we must identified the radius");
            Console.WriteLine("\t Once we identified the radius, we'll need to calculate the average");
            Console.WriteLine("\t Then we'll add and subtract the average to find the difference");
            Console.WriteLine("\n");
            Console.WriteLine("\t ------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("\t Please select the number of sequence on what you want to do...");
            Console.WriteLine("\t 1.  Add the circles");
            Console.WriteLine("\t 2.  Subtract the circle");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    double resultAdd;
                    Console.WriteLine("\t Lets enter the radius for these two circles");
                    Console.WriteLine("\t Please enter the radius of the first circle");
                    Circle firstCirA = new Circle(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\t Please enter the radius of the second circle");
                    Circle secCirA = new Circle(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("\n");
                    Console.WriteLine("\t Lets get the area of each circle!");
                    Console.WriteLine("\t --------------------------------------");
                    Console.WriteLine("\t Lets find the area of the first circle");
                    Console.WriteLine($"\t The radius that you enter is [ {firstCirA._radius} ] and the area is: |[ {firstCirA.area} ]|");
                    Console.WriteLine("\n");
                    Console.WriteLine("\t Lets find the area of the second circle");
                    Console.WriteLine($"\t The radius that you enter is [ {secCirA._radius} ] and the area is: |[ {secCirA.area} ]|");
                    Console.WriteLine("\n");
                    Console.WriteLine("\t Lets find the sum of the two circles...");
                    resultAdd = firstCirA.area + secCirA.area;
                    Console.WriteLine($"\t The sum of both circles are : [ {resultAdd} ]");
                    break;
                case 2:
                    double resultSubt;
                    Console.WriteLine("\t Lets enter the radius for these two circles");
                    Console.WriteLine("\t Please enter the radius of the first circle");
                    Circle firstCirS = new Circle(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("\t Please enter the radius of the second circle");
                    Circle secCirS = new Circle(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("\n");
                    Console.WriteLine("\t Lets get the area of each circle!");
                    Console.WriteLine("\t --------------------------------------");
                    Console.WriteLine("\t Lets find the area of the first circle");
                    Console.WriteLine($"\t The  radius that you enter is [ {firstCirS._radius} ] and the area is: \t |[ {firstCirS.calcarea()} ]|");
                    Console.WriteLine("\n");
                    Console.WriteLine("\t Lets find the area of the second circle");
                    Console.WriteLine($"\t The  radius that you enter is [ {secCirS._radius} ] and the area is: \t |[ {secCirS.calcarea()} ]|");
                    Console.WriteLine("\n");
                    Console.WriteLine("\t Lets find the difference between the two circles...");
                    resultSubt = Math.Abs(firstCirS.area - secCirS.area);
                    Console.WriteLine($"\t The difference of the area is : |[ {resultSubt} ]|");
                    break;
                default:
                {
                    Console.WriteLine("\t You enter in invalid function");
                    break;
                }
            }
            Console.WriteLine("\t ----------------------------------------------");
            Console.WriteLine("\t Would you like to continue calculating circle?");
            Console.WriteLine("\t Press 'Y' for Yes and 'N' for No");
            yes = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\t ----------------------------------------------");
        }
        Console.WriteLine("\t Lets go back to the previous menu...");
    }
    private double radius;
    public double _radius
    {
        get { return this.radius; }
        set { this.radius = value; }
    }
    private double area;
    public double _area
    {
        get { return this.area; }
        set { this.area = value; }
    }
    public Circle(double radius)
    {
            this.radius = radius;
            this.area = calcarea();

    }
    public double calcarea()
    {
        return Math.PI * this.radius * this.radius;
    }
    public static Circle operator +(Circle a, Circle b)
    {
        Circle newCirAdd = new Circle(a.radius + b.radius);
        a.calcarea();
        b.calcarea();
        newCirAdd.area = a.area + b.area;
        return newCirAdd;
    }
    public static Circle operator -(Circle i, Circle j)
    {
        Circle newCirSubt = new Circle(i.radius - j.radius);
        i.calcarea();
        j.calcarea();
        newCirSubt.area = i.area + j.area;
        return newCirSubt;
    }
}

