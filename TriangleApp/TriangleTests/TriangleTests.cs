using TriangleApp;

namespace TriangleTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CheckPerimeter()
        {
            Point pt1 = new Point(0, 0, "Точка 1");
            Point pt2 = new Point(1, 0, "Точка 2");
            Point pt3 = new Point(0, 1, "Точка 3");

            Triangle tr1 = new Triangle(pt1, pt2, pt3);

            double actualPerimeter = tr1.GetPerimeter();

            double expectedPerimeter = 3.4142;

            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.1);
        }
    }
}