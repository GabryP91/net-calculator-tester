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
        public void TestDivide( float num1, float num2)
        {
            try
            {
                float result = calculator.Divide(num1, num2);

                // Mi assicuro che il denominatore non sia zero per evitare divisione per zero
                if (num2 != 0)
                {
                    Assert.AreEqual(2, result);
                    Console.WriteLine($"Division Test: {num1} / {num2} = {result}");
                }
                else
                {
                    // Se il denominatore è zero, ci aspettiamo un'eccezione
                    Assert.Fail("La divisione per zero non dovrebbe essere permessa.");
                }
            }
            catch (DivideByZeroException ex)
            {
                // Se la divisione per zero viene tentata, il test passa in caso di eccezione
                Assert.IsTrue(num2 == 0, "La divisione per zero dovrebbe generare un'eccezione.");
                Console.WriteLine($"Errore durante la divisione: {ex.Message}");
            }
        }

        [Test]
        public void TestMultiply()
        {
            float result = calculator.Multiply(5, 3);
            Assert.AreEqual(15, result);
        }
    }
}