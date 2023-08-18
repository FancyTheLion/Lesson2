namespace TriangleApp
{
    /// <summary>
    /// Класс "треугольник"
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// Вершина A
        /// </summary>
        public Point A { get; private set; }

        /// <summary>
        /// Вершина B
        /// </summary>
        public Point B { get; private set; }

        /// <summary>
        /// Вершина C
        /// </summary>
        public Point C { get; private set; }

        /// <summary>
        /// Конструктор, он создаёт треугольник из трёх точек
        /// </summary>
        /// <param name="a">Точка a (она станет вершиной A)</param>
        /// <param name="b">Точка b (она станет вершиной B)</param>
        /// <param name="c">Точка c (она станет вершиной C)</param>
        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Распечатка треугольника
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Вершина А:");
            A.PrintCoords();

            Console.WriteLine("Вершина B:");
            B.PrintCoords();

            Console.WriteLine("Вершина C:");
            C.PrintCoords();
        }

        public double GetPerimeter()
        {
            return A.DistanceTo(B) + B.DistanceTo(C) + C.DistanceTo(A);
        }
    }
}
