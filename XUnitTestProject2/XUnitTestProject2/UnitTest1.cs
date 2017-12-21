using System;
using Xunit;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
  
        //Using the encoding method to create an encoded string, this test would be able to make sure the expected results are correct.
        [Fact]
        public void Test1()
        {
            Assert.Equal(EncodingMethod(pureString), encodedString);
        }
    }
}
