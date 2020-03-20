using Calculator;
using NUnit.Framework;

namespace CalculatorTests
{
    public class OperatorTests
    {

        public enum TestOperatorsList
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }
    


    [Test]
        public void GetOperatorTest()
        {
           // Assert.That(TestOperatorsList.Addition, Is.TypeOf();
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