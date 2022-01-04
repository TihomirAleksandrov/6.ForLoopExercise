using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentNum = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            double winCounter = 0;
            double averagePoints = 0;
            double winPercentage = 0;

            for (int i = 0; i < tournamentNum; i++)
            {
                string result = Console.ReadLine();

                if (result == "W")
                {
                    winCounter++;
                    startingPoints += 2000;
                    averagePoints += 2000;
                }
                else if (result == "F")
                {
                    startingPoints += 1200;
                    averagePoints += 1200;
                }
                else
                {
                    startingPoints += 720;
                    averagePoints += 720;
                }
            }

            averagePoints = averagePoints / tournamentNum;
            winPercentage = (winCounter / tournamentNum) * 100;

            Console.WriteLine($"Final points: {startingPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{winPercentage:f2}%");
        }
    }
}
