using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double moneyRecieved = 0;
            double birthdayMoney = 10;

            int oddCounter = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyRecieved += birthdayMoney;
                    moneyRecieved -= 1;
                    birthdayMoney += 10;
                }
                else
                {
                    oddCounter++;
                }
            }

            toyPrice *= oddCounter;
            moneyRecieved += toyPrice;

            if (moneyRecieved >= washingMachinePrice)
            {
                double moneyLeft = moneyRecieved - washingMachinePrice;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                double moneyNeeded = washingMachinePrice - moneyRecieved;
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}
