using System;
using Xunit;

namespace xUnitFeatures.LifeCycles
{
    [Collection("ContextOne")]
    public class TestContainerTwo : IDisposable
    {
        public TestContainerTwo()
        {
            "TestContainerTwo : ctor".Show();
        }

        [Fact]
        public void TestOne()
        {
            "TestContainerTwo : TestOne".Show();
        }

        public void Dispose()
        {
            "TestContainerTwo : disposed".Show();
        }
    }
}