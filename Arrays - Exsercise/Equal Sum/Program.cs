using System;
using System.Linq;
namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool flag = false;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                


                for (int j = i - 1; j >= 0; j--)
                {

                    leftSum += numbers[j];


                }


                int rightSum = 0;
                for (int k = i + 1; k < numbers.Length; k++)
                {


                    rightSum += numbers[k];

                }

                if (rightSum == leftSum)
                {
                    flag = true;
                    Console.WriteLine(i);
                   
                }







            }
            if (flag == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
