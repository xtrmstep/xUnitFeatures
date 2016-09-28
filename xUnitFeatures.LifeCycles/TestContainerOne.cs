using System;
using Xunit;

namespace xUnitFeatures.LifeCycles
{
    [Collection("ContextOne")]
    public class TestContainerOne : IClassFixture<ClassFixture>, IDisposable
    {
        public TestContainerOne()
        {
            "TestContainerOne : ctor".Show();
        }

        [Fact]
        public void TestOne()
        {
            "TestContainerOne : TestOne".Show();
        }

        [Fact]
        public void TestTwo()
        {
            "TestContainerOne : TestTwo".Show();
        }

        public void Dispose()
        {
            "TestContainerOne : disposed".Show();
        }
    }
}