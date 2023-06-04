using System;
using Xunit;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {
        [Fact]
        public void CanGetFactorial()
        {
            Assert.Equal(1, Algorithms.GetFactorial(0));
            Assert.Equal(1, Algorithms.GetFactorial(1));
            Assert.Equal(24, Algorithms.GetFactorial(4));
            Assert.Equal(120, Algorithms.GetFactorial(5));
            Assert.Throws<ArgumentOutOfRangeException>(() => Algorithms.GetFactorial(-1));
        }

        [Fact]
        public void CanFormatSeparators()
        {
            Assert.Equal("", Algorithms.FormatSeparators());
            Assert.Equal("", Algorithms.FormatSeparators(null));
            Assert.Equal("a", Algorithms.FormatSeparators("a"));
            Assert.Equal("a and b", Algorithms.FormatSeparators("a", "b"));
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c"));
        }
    }
}