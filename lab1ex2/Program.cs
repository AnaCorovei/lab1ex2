using System;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Ex2
            Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura*/

            int firstNumber, secondtNumber, thirdNumber;

            Console.WriteLine("Enter firstNumber: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter secondtNumber: ");
            secondtNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter thirdNumber: ");
            thirdNumber = int.Parse(Console.ReadLine());

            int mediaAritmetica = (firstNumber + secondtNumber + thirdNumber)/3;
            Console.WriteLine("Media Aritmetica este: " + mediaAritmetica);
        }
    }
}
