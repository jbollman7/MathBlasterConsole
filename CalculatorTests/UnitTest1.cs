using Calculator;
using NUnit.Framework;

namespace CalculatorTests
{
    public class OperatorTests
    {

        //simple unit test suite to test choice enum
        [Test]
        public void AEnumTest()
        {
            Assert.AreEqual(0, (int)ChoiceList.A);
        }
        [Test]
        public void BEnumTest()
        {
            Assert.AreEqual(1, (int)ChoiceList.B);
        }
        [Test]
        public void CEnumTest()
        {
            Assert.AreEqual(2, (int)ChoiceList.C);
        }
        [Test]
        public void DEnumTest()
        {
            Assert.AreEqual(3, (int)ChoiceList.D);
        }
        [Test]
        public void EEnumTest()
        {
            Assert.AreEqual(4, (int)ChoiceList.E);
        }
        [Test]
        public void FEnumTest()
        {
            Assert.AreEqual(5, (int)ChoiceList.F);
        }

        // simple unit test suite to test OperatorsList enum
        [Test]
        public void AdditionEnumIntTest()
        {
            Assert.AreEqual(0, (int)OperatorsList.Addition);
        }
        [Test]
        public void SubtractionEnumIntTest()
        {
            Assert.AreEqual(1, (int)OperatorsList.Subtraction);
        }
        [Test]
        public void MultiplicationEnumIntTest()
        {
            Assert.AreEqual(2, (int)OperatorsList.Multiplication);
        }
        [Test]
        public void DivisionEnumIntTest()
        {
            Assert.AreEqual(3, (int)OperatorsList.Division);
        }


        [Test]
        public void AdditionTest()
        {
            Assert.AreEqual(4, Operators.Add(2, 2));
        }
        [Test]
        public void SubtractionTest()
        {
            Assert.AreEqual(9, Operators.Subtract(13, 4));
        }
        [Test]
        public void MultiplicationTest()
        {
            Assert.AreEqual(81, Operators.Multiplication(9, 9));
        }
        [Test]
        public void DivisionTest()
        {
            Assert.AreEqual(8, Operators.Division(96, 12));
        }
    }
}