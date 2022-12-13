using Benchmarking;
using Xunit;

namespace UnitTests
{
    public class FixedConcatenationsTests
    {
        private const string result = "X = 1. Y = 2. Z = 3.";

        [Fact]
        public void Creation()
        {
            Assert.NotNull(new FixedConcatenations());
        }

        [Fact]
        public void Plus()
        {
            Assert.Equal(result, new FixedConcatenations().UsingPlus());
        }
        [Fact]
        public void PlusEquals()
        {
            Assert.Equal(result, new FixedConcatenations().UsingPlusEquals());
        }
        [Fact]
        public void Interpolation()
        {
            Assert.Equal(result, new FixedConcatenations().UsingInterpolation());
        }
        [Fact]
        public void Format()
        {
            Assert.Equal(result, new FixedConcatenations().UsingFormat());
        }
        [Fact]
        public void Builder()
        {
            Assert.Equal(result, new FixedConcatenations().UsingBuilder());
        }
    }
}