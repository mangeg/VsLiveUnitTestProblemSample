using Xunit;

namespace LiveUnitTestProblemSample.Test
{
    public class WorkingHelperClassTest
    {
        [Fact]
        public void TestWorkingHelperClass()
        {
            var result = WorkingHelperClass.DoWork();

            Assert.Equal("hello", result);
        }
    }
}