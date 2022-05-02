using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyOfIvanCho = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double totalMoneyForLightsavber = priceOfLightsaber * Math.Ceiling(countStudents * 1.1);
           
            double totalMoneyForBelts = (priceOfBelt * countStudents) - (countStudents / 6 * priceOfBelt);
            
            double totalMoney = totalMoneyForLightsavber + priceOfRobe * countStudents + totalMoneyForBelts;


            if (totalMoney <= moneyOfIvanCho)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalMoney - moneyOfIvanCho):F2}lv more.");
            }
        }
    }
}
