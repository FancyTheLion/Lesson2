using CarsApp.Abstractions;

namespace CarsApp.Concrete
{
    public class Truck : Car, ITruck
    {
        /// <summary>
        /// Размер груза
        /// </summary>
        public int CargeSize { get; private set; }

        public Truck
        (
            string brand,
            int numberOfWindows,
            int theWeightOfTheCar,
            int cargeSize
        ) : base(brand, numberOfWindows, theWeightOfTheCar)
        {
            cargeSize = CargeSize;
        }

        public void PrintCargeSize()
        {
            Console.WriteLine($"Грузовой автомобиль вмещает в себя груза: { CargeSize }");
        }
    }
}
