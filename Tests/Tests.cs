using System;
using Xunit;
using static IsPositive;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void CanTellIfPositive()
        {
            int zero = 0;
            int positive = 1;
            int negative = -1;

            Assert.True(IsPositive.Check(positive));
            Assert.False(IsPositive.Check(zero));
            Assert.False(IsPositive.Check(negative));
        }
    }
}
