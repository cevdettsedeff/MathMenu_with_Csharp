using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMenu_with_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cevdettsedefff

            Console.WriteLine("--------------------");
            Console.WriteLine("Welcome to Math Menu!");
            Console.WriteLine("--------------------");

            Console.WriteLine("1.Arithmetic Four Operations");
            Console.WriteLine("2.Exponentiation Of A Number");
            Console.WriteLine("3.Rectangular Area Calculation");
            Console.WriteLine("3.Rectangular Volume Calculation");
            Console.WriteLine("5.Circle Area Calculation");
            
            Console.WriteLine("--------------------");

            Console.WriteLine("Please choose one of the operations!");
            Console.Write("Choosen Operation: ");
            int operation;
            operation=Convert.ToInt16(Console.ReadLine());

            if(operation==1)
            {
                int n1, n2, addition, subtraction, multiply, divide;
                Console.Write("\nPlease enter the first value: ");
                n1 = Convert.ToInt16(Console.ReadLine());

                Console.Write("Please enter the second value: ");
                n2 = Convert.ToInt16(Console.ReadLine());

                addition=n1 + n2;
                subtraction=n1 - n2;
                multiply=n1 * n2;
                divide=n1 / n2;

                Console.WriteLine("\nAddition: {0} \nSubtraction: {1} \nMultiply: {2} \nDivide: {3}" , addition , subtraction , multiply , divide);
            }

            if(operation==2)
            {
                double n1, exp, result;
                Console.Write("\nPlease enter the first value: ");
                n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the exponential value: ");
                exp = Convert.ToDouble(Console.ReadLine());

                result = Math.Pow(n1, exp);
                Console.WriteLine("\nResult: " + result);
            }

            if(operation==3)
            {
                int n1, n2, result;
                Console.Write("\nPlease enter the value of the short side:  ");
                n1 = Convert.ToInt16(Console.ReadLine());

                Console.Write("Please enter the value of the long side: ");
                n2 = Convert.ToInt16(Console.ReadLine());

                result = n1 * n2;
                Console.WriteLine("\nThe area of the rectangular shape: " + result);
            }

            if( operation==4)
            {
                double n1, n2, n3, result;
                Console.Write("\nPlease enter the value of the short side:  ");
                n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the value of the long side: ");
                n2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the value of depth:  ");
                n3 = Convert.ToDouble(Console.ReadLine());

                result = n1 * n2 * n3;
                Console.WriteLine("\nThe volume of the rectangular shape: " + result);

            }

            if(operation==5)
            {
                double pi = 3.14;
                double radius, result;

                Console.Write("\nEnter the radius value: ");
                radius = Convert.ToDouble(Console.ReadLine());

                result = pi * radius * radius;
                Console.WriteLine("\nArea of the circle: " + result);
            }

            //cevdettsedeff

            Console.ReadLine();
        }
    }
}
