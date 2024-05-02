using NUnit.Framework;

namespace UnitTest.Editor
{
    public class UnitTestExample
    {
        [Test]
        public void sum_values()
        {
            var valueA = 10;
            var valueB = 2;
        
            var mathOperation = new MathOperation();

            var result = mathOperation.Sum(valueA, valueB);
        
            Assert.AreEqual(expected: 12, result);
        }

        [Test]
        public void duplicate_value()
        {
            var value = 7;
            
            var mathOperation = new MathOperation();

            var result = mathOperation.Duplicate(value);
            
            Assert.AreEqual(expected: 14, result);
        }

    }
}