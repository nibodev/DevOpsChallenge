using Xunit;

namespace XUnit.Project
{
    [TestCaseOrderer("XUnit.Project.Orderers.AlphabeticalOrderer", "XUnit.Tests")]
    public class ByAlphabeticalOrder
    {
        public static bool Test1Called = false;
        public static bool Test2Called = false;
        public static bool Test3Called = false;

        [Fact]
        public void Test1()
        {
            Test1Called = true;

            Assert.False(Test2Called);
            Assert.False(Test3Called);
        }

        [Fact]
        public void Test2()
        {
            Test2Called = true;

            Assert.True(Test1Called);
            Assert.False(Test3Called);
        }

        [Fact]
        public void Test3()
        {
            Test3Called = true;

            Assert.True(Test1Called);
            Assert.True(Test2Called);
        }
    }
}
