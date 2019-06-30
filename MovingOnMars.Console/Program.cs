namespace MovingOnMars.Console
{
    using System;

    using MovingOnMars.Bussiness;

    internal class Program
    {
        private static void Main(string[] args)
        {
            bool loopInterupt = false;
            while (!loopInterupt)
            {
                Console.WriteLine("Enter Grid Area:");
                var gridarea = Console.ReadLine();

                Console.WriteLine("Enter Position:");
                var position = Console.ReadLine();

                Console.WriteLine("Enter Command:");
                var command = Console.ReadLine();

                IVehicleManager vehicleManager =  VehicleManager.Create(gridarea, position, command);
                var result = vehicleManager.Operation();

                Console.WriteLine(result);

                Console.WriteLine("For Exit 'X'");
                var key = Console.ReadKey();
                loopInterupt = key.Key == ConsoleKey.X;
            }

        }
    }
}