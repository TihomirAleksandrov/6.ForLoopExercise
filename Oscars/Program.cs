using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double actorPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string jury = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());
                int namePoints = jury.Length;

                juryPoints = (namePoints * juryPoints) / 2;
                actorPoints += juryPoints;

                if (actorPoints >= 1250.5)
                {
                    i = n;
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {actorPoints:f1}!");
                }

            }

            if (actorPoints < 1250.5)
            {
                double pointsNeeded = 1250.5 - actorPoints;
                Console.WriteLine($"Sorry, {actorName} you need {pointsNeeded:f1} more!");
            }
        }
    }
}
