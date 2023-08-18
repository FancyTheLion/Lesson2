namespace TriangleApp
{
    /// <summary>
    /// Это класс, представляющий собой точку
    /// </summary>
    public class Point
    {
        /// <summary>
        /// X-координата точки (свойство)
        /// </summary>
        public double X { get; private set; }

        /// <summary>
        /// Y-координата точка (свойство)
        /// </summary>
        public double Y { get; private set; }

        /// <summary>
        /// Имя точки (свойство)
        /// </summary>
        public string Name { get; private set; }


        /// <summary>
        /// Я - конструктор, я ставлю точку на бумагу
        /// </summary>
        /// <param name="x">Где ставить точку - координата X</param>
        /// <param name="y">Где ставить точку - координата Y</param>
        /// <param name="name">Имя точки</param>
        public Point(double x, double y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

        /// <summary>
        /// Я - метод, я печатаю координаты КОНКРЕТНОЙ точки
        /// </summary>
        public void PrintCoords()
        {
            Console.WriteLine($"Имя: {Name} X = {X}, Y = {Y}");
        }

        /// <summary>
        /// Расчитать дистанцию до другой точки
        /// </summary>
        /// <param name="secondPoint">Другая точка, которая получит имя secondPoint</param>
        /// <returns>Дистанция</returns>
        public double DistanceTo(Point secondPoint)
        {
            Console.WriteLine($"Вычисляю расстояние от точки { Name } до точки { secondPoint.Name }");
            return Math.Sqrt(Math.Pow(X - secondPoint.X, 2) + Math.Pow(Y - secondPoint.Y, 2));
        }
    }
}
