using Shape;

namespace ShapeTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            IShape circle = new Circle(12);
            Assert.AreEqual(Math.PI * 12 * 12, circle.Area(), 0.0001);
        }
    }
}