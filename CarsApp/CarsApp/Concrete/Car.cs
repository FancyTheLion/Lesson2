using CarsApp.Abstractions;
using System.Security.Cryptography.X509Certificates;

namespace CarsApp.Concrete
{
    public class Car : ICar
    {
        /// <summary>
        /// Марка машины
        /// </summary>
        protected string Brand { get; private set; }

        /// <summary>
        /// Количество окон
        /// </summary>
        protected int NumberOfWindows { get; private set; }

        /// <summary>
        /// Средний вес машины
        /// </summary>
        protected int TheWeightOfTheCar { get; private set; }

        public Car
        (
            string brand,
            int numberOfWindows,
            int theWeightOfTheCar
        )
        {
            Brand = brand;
            NumberOfWindows = numberOfWindows;
            TheWeightOfTheCar = theWeightOfTheCar;
        }

        public void StartEngine()
        {
            Console.WriteLine("Запуск двигателя");
        }

        public void StopEngine()
        {
            Console.WriteLine("Остановка двигателя");
        }

        public void DriveTo(string destination) // Машина такая то, едет туда то, столько колес, столько то окон
        {
            Console.WriteLine($"Автомобиль марки {Brand}, имеющий {TheWeightOfTheCar} колеса и {NumberOfWindows} окон, двигается в {destination}");
        }
    }
}
