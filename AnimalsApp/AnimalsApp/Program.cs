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

            IMammal fanci = new Lion("Фанси", Sex.Male, Orientation.Gay, ManeColor.White);

            IMammal ulus = new Tiger("Юлус", Sex.Male, Orientation.Straight, 150);

            fanci.Yiff(ulus);


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