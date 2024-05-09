using net_calculator_tester;
namespace TestCalc
{
    public class Tests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TestAdd()
        {
            float result = calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void TestSubtract()
        {
            float result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        [TestCase(2,2)]
        [TestCase(0, 0)]
        [TestCase(2, "")]
        public void TestDivide( float num1, float num2)
        {
            float result = calculator.Divide(num1, num2);
            Assert.AreEqual(2, result);

            Console.WriteLine($"Division Test: {num1} / {num2} = {result}");
        }

        [Test]
        public void TestMultiply()
        {
            float result = calculator.Multiply(5, 3);
            Assert.AreEqual(15, result);
        }
    }
}