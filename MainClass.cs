using System;

using CalculatorLibrary;

namespace CalculatorApplication
{
    class MyCalculator:Calculator
    {
        public MyCalculator(int x, int y) : base(x, y)
        {

        }
        public MyCalculator()
        {

        }
        static void Main()
        {
            Console.Write("Enter First Number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int j = int.Parse(Console.ReadLine());

            MyCalculator mycal = new MyCalculator(i, j);

            Console.WriteLine("{0}+{1}={2}", mycal.FirstNumber, mycal.SecondNumber, mycal.Add());
            Console.WriteLine("{0}-{1}={2}", mycal.FirstNumber, mycal.SecondNumber, mycal.Sub());
            Console.WriteLine("{0}*{1}={2}", mycal.FirstNumber, mycal.SecondNumber, mycal.Mul());
            Console.WriteLine("{0}/{1}={2}", mycal.FirstNumber, mycal.SecondNumber, mycal.Div());

            Console.WriteLine("-------------------------------------------------------------------------------------");

            Console.Write("Enter First Number: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            j = int.Parse(Console.ReadLine());

            mycal = new MyCalculator();
            mycal.FirstNumber = i;
            mycal.SecondNumber = j;

            Console.WriteLine("{0}+{1}={2}", mycal.FirstNumber, mycal.SecondNumber, mycal.Add());
            Console.WriteLine("{0}-{1}={2}", mycal.FirstNumber, mycal.SecondNumber, mycal.Sub());
            Console.WriteLine("{0}*{1}={2}", mycal.FirstNumber, mycal.SecondNumber, mycal.Mul());
            Console.WriteLine("{0}/{1}={2}", mycal.FirstNumber, mycal.SecondNumber, mycal.Div());
        }

    }
}
