using AnimalsApp.Abstractions;
using AnimalsApp.Concrete;
using AnimalsApp.Enumerations;

namespace AnimalsApp
{
    public class Program
    {
        /// <summary>
        /// Кнопка, которую надо нажать для выхода из программы
        /// </summary>
        private const ConsoleKey ExitKey = ConsoleKey.Q;

        static void Main(string[] args)
        {
/*            IMammal mammal1 = new Mammal("Грейси", Sex.Female, Orientation.Straight);
            IMammal mammal2 = new Mammal("Ин ге а Харра", Sex.Male, Orientation.Gay);

            mammal1.Yiff(mammal2); // Тот объект, по которому вызывается метод, становится доступным
             в переменной this внутри метода*/

            Lion fanci = new Lion("Фанси", Sex.Male, Orientation.Gay, ManeColor.White);

            Tiger ulus = new Tiger("Юлус", Sex.Male, Orientation.Straight, 150);

            Zebra sera = new Zebra("Сера", Sex.Female, Orientation.Straight, 250);

            // Проверяем всех зверей на полосатость
            Console.WriteLine($"Фанси - полосат? { fanci is IAnimalsWithStripes }");
            Console.WriteLine($"Улус - полосат? {ulus is IAnimalsWithStripes}");
            Console.WriteLine($"Сера - полосата? {sera is IAnimalsWithStripes}");

            IAnimalsWithStripes stripedAnimal1 = ulus as IAnimalsWithStripes;
            stripedAnimal1.TellAboutStripse();

            //            fanci.Yiff(ulus);


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