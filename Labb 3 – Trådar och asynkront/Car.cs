using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb_3___Trådar_och_asynkront
{
    public class Car
    {
        private string _carName;
        private string _carColour;
        private int _carSpeed;
        private int _carDistanceTraveled;
        private int _trackLength;

        public Car(string carName, string carColour, int carSpeed, int trackLength)
        {
            this._carName = carName;
            this._carColour = carColour;
            this._carSpeed = carSpeed;
            this._carDistanceTraveled = 0;
            this._trackLength = trackLength;
        }

        public void PrintAllTheCars()
        {
            Console.WriteLine($"Name of the car : {_carName}.");
            Console.WriteLine($"Colour of the car : {_carColour}.");
            Console.WriteLine($"Speed of the car : {_carSpeed} km/h.");
            Console.WriteLine($"Distance left for the car to drive : {_trackLength - _carDistanceTraveled} kilometers.");
        }

        public static List<string> _leaderboard = new List<string>();

        private bool _race = true;
        public void RaceInProgress()
        {
            while (_race == true)
            {
                for (_carDistanceTraveled = 0; _carDistanceTraveled <= _trackLength; _carDistanceTraveled++)
                {
                    Thread.Sleep(7000);

                    Random randomEvent = new Random();
                    int re = randomEvent.Next(0, 51);

                    if (re == 1)
                    {
                        if (Thread.CurrentThread.Name == "Demolisher")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{Thread.CurrentThread.Name} has run out of gas! It needs to be refuelled.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(30000);
                            Console.WriteLine();
                        }
                        if (Thread.CurrentThread.Name == "Prowler")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{Thread.CurrentThread.Name} has run out of gas! It needs to be refuelled.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(30000);
                            Console.WriteLine();
                        }
                        if (Thread.CurrentThread.Name == "Centurion")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{Thread.CurrentThread.Name} has run out of gas! It needs to be refuelled.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(30000);
                            Console.WriteLine();
                        }
                    }

                    else if (re == 2 || re == 3)
                    {
                        if (Thread.CurrentThread.Name == "Demolisher")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{Thread.CurrentThread.Name} has blown a tire! It needs to be replaced.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(20000);
                            Console.WriteLine();
                        }
                        if (Thread.CurrentThread.Name == "Prowler")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{Thread.CurrentThread.Name} has blown a tire! It needs to be replaced.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(20000);
                            Console.WriteLine();
                        }
                        if (Thread.CurrentThread.Name == "Centurion")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{Thread.CurrentThread.Name} has blown a tire! It needs to be replaced.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(20000);
                            Console.WriteLine();
                        }
                    }

                    else if (re > 3 && re < 9)
                    {
                        if (Thread.CurrentThread.Name == "Demolisher")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"A bird just smashed into {Thread.CurrentThread.Name}’s front window! It will take some time to clean it.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(10000);
                            Console.WriteLine();
                        }
                        if (Thread.CurrentThread.Name == "Prowler")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"A bird just smashed into {Thread.CurrentThread.Name}’s front window! It will take some time to clean it.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(10000);
                            Console.WriteLine();
                        }
                        if (Thread.CurrentThread.Name == "Centurion")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"A bird just smashed into {Thread.CurrentThread.Name}’s front window! It will take some time to clean it.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(10000);
                            Console.WriteLine();
                        }
                    }

                    else if (re > 8 && re < 19)
                    {
                        if (Thread.CurrentThread.Name == "Demolisher")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{Thread.CurrentThread.Name} has just experienced an issue with its engine!");
                            Console.ForegroundColor = ConsoleColor.White;
                            _carSpeed = _carSpeed - 1;
                            Console.WriteLine();
                        }
                        if (Thread.CurrentThread.Name == "Prowler")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{Thread.CurrentThread.Name} has just experienced an issue with its engine!");
                            Console.ForegroundColor = ConsoleColor.White;
                            _carSpeed = _carSpeed - 1;
                            Console.WriteLine();
                        }
                        if (Thread.CurrentThread.Name == "Centurion")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{Thread.CurrentThread.Name} has just experienced an issue with its engine!");
                            Console.ForegroundColor = ConsoleColor.White;
                            _carSpeed = _carSpeed - 1;
                            Console.WriteLine();
                        }
                    }

                    if (_carDistanceTraveled == _trackLength)
                    {
                        if (Thread.CurrentThread.Name == "Demolisher")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{Thread.CurrentThread.Name} has just crossed the finish line!");
                            Console.ForegroundColor = ConsoleColor.White;
                            _leaderboard.Add(_carName);
                            Console.WriteLine();
                            _race = false;
                        }
                        if (Thread.CurrentThread.Name == "Prowler")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{Thread.CurrentThread.Name} has just crossed the finish line!");
                            Console.ForegroundColor = ConsoleColor.White;
                            _leaderboard.Add(_carName);
                            Console.WriteLine();
                            _race = false;
                        }
                        if (Thread.CurrentThread.Name == "Centurion")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{Thread.CurrentThread.Name} has just crossed the finish line!");
                            Console.ForegroundColor = ConsoleColor.White;
                            _leaderboard.Add(_carName);
                            Console.WriteLine();
                            _race = false;
                        }
                    }
                }
            }
        }
    }
}
