using System;
using System.Threading;

namespace Labb_3___Trådar_och_asynkront
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Demolisher", "Yellow", 100, 10);
            Car car2 = new Car("Prowler", "Blue", 100, 10);
            Car car3 = new Car("Centurion", "Red", 100, 10);

            Thread tCar1 = new Thread(car1.RaceInProgress);
            Thread tCar2 = new Thread(car2.RaceInProgress);
            Thread tCar3 = new Thread(car3.RaceInProgress);

            tCar1.Name = "Demolisher";
            tCar2.Name = "Prowler";
            tCar3.Name = "Centurion";

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Input status if you want to see the cars current status.");
            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Rev up your engines! The race will commence in 3..."); Thread.Sleep(1500);
            Console.WriteLine("2..."); Thread.Sleep(1500);
            Console.WriteLine("1..."); Thread.Sleep(1500);
            Console.WriteLine("Go! Burn rubber!");
            Console.WriteLine();

            tCar1.Start();
            tCar2.Start();
            tCar3.Start();

            while (tCar1.IsAlive || tCar2.IsAlive || tCar3.IsAlive)
            {
                string printStatus = Console.ReadLine();
                if (printStatus == "status")
                {
                    car1.PrintAllTheCars();
                    Console.WriteLine();
                    car2.PrintAllTheCars();
                    Console.WriteLine();
                    car3.PrintAllTheCars();
                }
            }

            Console.WriteLine("The results are in!");
            Console.WriteLine($"In third place we have {Car._leaderboard[2]}"); Thread.Sleep(2000);
            Console.WriteLine($"In second place we find {Car._leaderboard[1]}"); Thread.Sleep(2000);
            Console.WriteLine($"That means {Car._leaderboard[0]} has taken the first spot on the pedestal! Congratulations!!!");

            Console.ReadKey();
        }
    }
}
