namespace TriangleApp
{
    public class Program
    {
        /// <summary>
        /// Кнопка, которую надо нажать для выхода из программы
        /// </summary>
        private const ConsoleKey ExitKey = ConsoleKey.Q;

        public static void Main(string[] args)
        {
            Point pt1 = new Point(23, 45, "Т1");
            Point pt2 = new Point(56, 67, "Т2");
            Point pt3 = new Point(78, 89, "Т3");

            Triangle tr1 = new Triangle(pt1, pt2, pt3);

            tr1.Print();

            double perimeter = tr1.GetPerimeter();

            Console.WriteLine($"Периметр: {perimeter}");

            WaitForExit();
        }

        public static void WaitForExit()
        {
            Console.WriteLine($"Нажмите {ExitKey} для завершения работы");

            // Нужно бесконечно читать с клавиатуры символы, если попался Q - завершать работу
            while (true)
            {
                var key = Console.ReadKey();

                // Если Q - то выполнить то, что в теле IF, т.е. выход из программы
                if (key.Key == ExitKey)
                {
                    Environment.Exit(0); // 0 означает "программа завершилась без ошибок"
                }
            }
        }
    }
}