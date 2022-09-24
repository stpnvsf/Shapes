using Area;

namespace ShapesTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-1,-1,-1)]
        [TestCase(1,-1,-1)]
        [TestCase(1,1,-1)]
        [TestCase(1,1,0)]
        [TestCase(1,-1,0)]
        [TestCase(1,0,0)]
        [TestCase(0,0,0)]
        public void InitTriangleWithErrorTest(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void InitTriangleTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            Triangle triangle = new Triangle(a, b, c);

            Assert.NotNull(triangle);
            Assert.That(a, Is.EqualTo(triangle.SideA));
            Assert.That(b, Is.EqualTo(triangle.SideB));
            Assert.That(c, Is.EqualTo(triangle.SideC));
        }

        [Test]
        public void InitNotTriangle()
        {

            Assert.Catch<ArgumentException>(() => new Triangle(1, 2, 1));
        }

        [Test]
        public void GetAreaTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double result = 6;
            
            Triangle triangle = new Triangle(a, b, c);

            double area = triangle.getArea();

            Assert.That(area, Is.EqualTo(result));

        }

        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(3, 4, 3, ExpectedResult = false)]
        public bool NotRightTriangle(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);

            bool result = triangle.IsRight;
            return result;  
        }

    }
}