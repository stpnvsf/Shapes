using System;
using Area;

namespace ShapesTest
{
    public class CircleTest
    {
        [Test]
        public void ZeroRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(0));
        }

        [Test]
        public void NegativeRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-1));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void GetAreaTest(double r)
        {
            Circle circle = new Circle(r);
            
            double result = circle.getArea();

            Assert.That(result, Is.EqualTo(Math.PI * Math.Pow(r, 2)));
        }
    }
}
