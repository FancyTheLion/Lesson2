using CarsApp.Concrete;

namespace CarsApp
{
    internal class Program
    {
        /// <summary>
        /// Кнопка, которую надо нажать для выхода из программы
        /// </summary>
        private const ConsoleKey ExitKey = ConsoleKey.Q;

        static void Main(string[] args)
        {
            PassengerCar renault = new PassengerCar("Рено", 4, 1300, 4);
            renault.DriveTo("Бар");
            renault.PrintCapacity();


            Truck volvo = new Truck("Вольво", 2, 9500, 18000);
            volvo.DriveTo("Горица");
            volvo.PrintCargeSize();

            WaitForExit();
        }

        public static void WaitForExit()
        {
            Console.WriteLine($"Нажмите {ExitKey} для завершения работы");

            while (true)
            {
                var key = Console.ReadKey();

                if (key.Key == ExitKey)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}