using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberTree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());

            int resultOne = numberOne + numberTwo;
            int resultTwo = resultOne / numberTree;
            int resultTree = resultTwo * numberFour;
            Console.WriteLine(resultTree);
        }
    }
}
