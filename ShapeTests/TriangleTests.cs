using Shape;

namespace ShapeTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleAreaTest()
        {
            IShape triangle = new Triangle(1, 2, 2.5);
            Assert.AreEqual(0.95, triangle.Area(), 0.0001);
        }

        [TestMethod]
        public void TriangleIsRightTest()
        {
            Triangle triangle = new Triangle(2, 3, 4);
            Assert.IsTrue(triangle.IsRight());
        }

        [TestMethod]
        public void TriangleIsNotRightTest()
        {
            Triangle triangle = new Triangle(1, 2, 3);
            Assert.IsFalse(triangle.IsRight());
        }
    }
}