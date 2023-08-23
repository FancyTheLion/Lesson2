using CarsApp.Abstractions;

namespace CarsApp.Concrete
{
    public class Truck : Car, ITruck
    {
        /// <summary>
        /// Размер груза
        /// </summary>
        public int CargoSize { get; private set; }

        public Truck
        (
            string brand,
            int numberOfWindows,
            int theWeightOfTheCar,
            int cargeSize
        ) : base(brand, numberOfWindows, theWeightOfTheCar)
        {
            CargoSize = cargeSize;
        }

        public void PrintCargeSize()
        {
            Console.WriteLine($"Грузовой автомобиль вмещает в себя груза: { CargoSize }");
        }
    }
}
