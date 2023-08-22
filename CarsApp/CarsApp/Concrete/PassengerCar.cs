using CarsApp.Abstractions;

namespace CarsApp.Concrete
{
    public class PassengerCar : Car, IPassengerCar
    {
        /// <summary>
        /// Вместимость легкового автомобиля
        /// </summary>
        public int Capacity { get; private set; }

        public PassengerCar
        (
            string brand,
            int numberOfWindows,
            int theWeightOfTheCar,
            int capacity
        ) : base(brand, numberOfWindows, theWeightOfTheCar)
        {
            Capacity = capacity;
        }

        public void PrintCapacity()
        {
            Console.WriteLine($"Вместимость легкового автомобиля: { Capacity }");
        }
    }
}
