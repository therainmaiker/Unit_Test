using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace CalculatorTest
{
    public class UnitTest1
    {
        private Calculator.Calculator _calcul;

        public UnitTest1()
        {
            _calcul = new Calculator.Calculator();
        }

        [Fact]
        public void AdditionTest()
        {
            var result = _calcul.Addition(5, 5);
            Assert.Equal(10, result);
        }

        [Fact]
        public void SubtractionTest()
        {
            var result = _calcul.Subtraction(4, 3);
            Assert.Equal(1, result);
        }


        [Fact]
        public void DivideTest()
        {
            var result = _calcul.Division(8, 2);
            Assert.Equal(4, result);
        }
        
        [Fact]
        public void MultiplicationTest()
        {
            var result = _calcul.Multiplication(5, 2);
            Assert.Equal(10, result);
        }
    }
}