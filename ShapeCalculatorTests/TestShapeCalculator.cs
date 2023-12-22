using ShapeCalculator;

namespace ShapeCalculatorTests
{
    [TestClass]
    public class TestShapeCalculator
    {
        [TestMethod]
        public void Circle_GetArea()
        {
            IShape circle = new Circle(3);
            Assert.AreEqual(Math.PI * 9, circle.GetArea());
        }

        [TestMethod]
        public void Triangle_GetArea()
        {
            IShape triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetArea());
        }

        [TestMethod]
        public void Triangle_IsRightTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }
    }
}