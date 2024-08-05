using Lab7_Code;

namespace Lab7_Test
{
    [TestFixture]
    public class Tests
    {
        ICalculator myCalc;
        [SetUp]
        public void Setup()
        {
            myCalc = new MyCalculator();
        }

        [TearDown]
        public void Teardown() 
        {
            myCalc = null;
        }

       /* [Test]
        public void Test1()
        {
            Assert.Pass();
        }*/

        [Test]
        public void AddTest() {
            double result = myCalc.Add(2, 3);
            Assert.AreEqual(5, result);
        }


        [Test]
        [TestCase(-5, -3, -8)]
        [TestCase(-5, -4, -9)]
        public void Add3ArgumentsTest(int a, int b, int c)
        {
            double result = myCalc.Add(a, b);
            Assert.AreEqual(-9, c);
        }

        [Test]
        public void SubtractTest()
        {
            double result = myCalc.Subtract(2, 3);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void MultiplyTest()
        {
            double result = myCalc.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void DivideTest() 
        {
            double result = myCalc.Divide(6, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void DivideByZeroTest()
        {
            Assert.Throws<DivideByZeroException>(() => myCalc.Divide(6, 0));
        }
    }
}