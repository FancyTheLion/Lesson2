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
            Console.WriteLine("Hello, World!");
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