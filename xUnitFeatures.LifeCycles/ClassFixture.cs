using System;

namespace xUnitFeatures.LifeCycles
{
    public class ClassFixture : IDisposable
    {
        public ClassFixture()
        {
            "ClassFixture : ctor".Show();
        }

        public void Dispose()
        {
            "ClassFixture : disposed".Show();
        }
    }
}