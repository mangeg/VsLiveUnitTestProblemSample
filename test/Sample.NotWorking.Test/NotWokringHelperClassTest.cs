using Xunit;

namespace LiveUnitTestProblemSample.Test
{
    public class NotWokringHelperClassTest
    {
        [Fact]
        public void TestNotWorkingHelperClass()
        {
            var result = NotWorkingHelperClass.DoWork();

            Assert.Equal("hello", result);
        }
    }
}