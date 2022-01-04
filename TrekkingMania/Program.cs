using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsNum = int.Parse(Console.ReadLine());

            double moussalaCount = 0;
            double montblancCount = 0;
            double kilimanjaroCount = 0;
            double k2Count = 0;
            double everestCount = 0;
            int totalPeople = 0;

            for (int i = 0; i < groupsNum; i++)
            {
                int peopleNum = int.Parse(Console.ReadLine());
                totalPeople += peopleNum;

                if (peopleNum <= 5)
                {
                    moussalaCount += peopleNum;
                }
                else if (peopleNum > 5 && peopleNum <= 12)
                {
                    montblancCount += peopleNum;
                }
                else if (peopleNum > 12 && peopleNum <= 25)
                {
                    kilimanjaroCount += peopleNum;
                }
                else if (peopleNum > 25 && peopleNum <= 40)
                {
                    k2Count += peopleNum;
                }
                else
                {
                    everestCount += peopleNum;
                }
            }

            double moussalaPercentage = moussalaCount / totalPeople * 100;
            double montblancPercentage = montblancCount / totalPeople * 100;
            double kilimanjaroPercentage = kilimanjaroCount / totalPeople * 100;
            double k2Percentage = k2Count / totalPeople * 100;
            double everestPercentage = everestCount / totalPeople * 100;

            Console.WriteLine($"{moussalaPercentage:f2}%");
            Console.WriteLine($"{montblancPercentage:f2}%");
            Console.WriteLine($"{kilimanjaroPercentage:f2}%");
            Console.WriteLine($"{k2Percentage:f2}%");
            Console.WriteLine($"{everestPercentage:f2}%");
        }
    }
}
