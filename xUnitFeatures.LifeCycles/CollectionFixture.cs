using System;

namespace xUnitFeatures.LifeCycles
{
    public class CollectionFixture : IDisposable
    {
        public CollectionFixture()
        {
            "CollectionFixture : ctor".Show();
        }

        public void Dispose()
        {
            "CollectionFixture : disposed".Show();
        }
    }
}