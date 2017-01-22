using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_14_16_20
{
    class Program
    {
        static void Main(string[] args)
        {
            ch4ex14();
            ch4ex16();
            ch4ex20();
        }

        //Write a C# program that inputs the radius of a circle and outputs its circumference.
        //Allow the user to repeat the calculation as often as desired.Use Math.PI for the value
        //of pi. The circumference of a circle is pi times the diameter. The diameter of a circle is
        //twice the radius.
        public static void ch4ex14()
        {
            String userContinue = "y";
            do
            {
                Console.Write("\nEnter radius of a circle: ");
                double r = double.Parse(Console.ReadLine());
                double c = (2 * r) * Math.PI;
                Console.Write("\nThe circumference of the circle is " + c);
                Console.Write("\nContinue? (y) or (n)");
                userContinue = Console.ReadLine();
            } while (userContinue == "y");

        }

        //The ancient Babylonians used a divide and average method for computing the square root
        //of a positive number x.First estimate the square root by some value r; any positive estimate
        //will do. Then compute the quotient, x/r.Averaging r and x/r gives a better estimate,
        //so continue the process, dividing and averaging until the estimates agree to the   
        //desired number of places.For example, to compute the square root of 2

        //estimate 1 divide 2/1 = 2 average (1+2)/2 = 1.5
        //estimate 1.5 divide 2/1.5 = 1.33 average(1.5+1.33)/2 = 1.415
        //estimate 1.415 .... and so on.

        //Write a C# program to compute the square root of a number input by the user. Use the
        //divide and average method and stop after 10 repetitions of the divide and average steps.
        //Compare your result with the value produced by the Sqrt method of the Math class.
        public static void ch4ex16()
        {
            String userContinue = "y";
            do
            {
                Console.Write("\nEnter number: ");
                double userNum = double.Parse(Console.ReadLine());
                double x = userNum;
                double y;

                for (int i = 0; i < 10; i++)
                {
                    y = (2 / x);
                    x = (x + y) / 2;
                }
                Console.Write("\nThe Babylonian square root of " + userNum + " is " + x);
                Console.Write("\nContinue? (y) or (n)");
                userContinue = Console.ReadLine();
            }while(userContinue == "y");
        }


        //Write a C# program that converts currencies between British currency of pounds and
        //pence, in which 1 pound contains 100 pence, and U.S.currency in dollars and cents.
        //Assume an exchange rate of 1.6595 U.S.dollars per British pound. Give the user a menu
        //to choose the type of conversion.Allow the user to repeat as often as desired. (See Test
        //Your Understanding questions 39 and 41.)
        public static void ch4ex20()
        {
            const double dollarPerPound = 1.6595;
            const double pencePerPound = 100;

            int choice = 3;
            do
            {
                Console.Write("\nChoose: \n"
                + "1. Convert from Pounds to Pence \n"
                + "2. Convert from Pounds to US Dollar \n"
                + "3. Quit \n");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter number of pounds: ");
                        double pounds = double.Parse(Console.ReadLine());
                        double pence = pencePerPound * pounds;
                        Console.Write("\n" + pounds + " pounds converts to " + pence + " pence.");
                        break;
                    case 2:
                        Console.Write("Enter number of pounds: ");
                        pounds = double.Parse(Console.ReadLine());
                        double dollars = dollarPerPound * pounds;
                        Console.Write("\n" + pounds + " pounds converts to " + dollars + " dollars.");
                        break;
                    case 3:
                        Console.WriteLine("Exiting Converter");
                        break;
                }
            } while (choice != 3);
        }
    }
}
