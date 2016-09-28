using Xunit;

namespace xUnitFeatures.LifeCycles
{
    [CollectionDefinition("ContextOne")]
    public class TestCollection : ICollectionFixture<CollectionFixture>
    {
        public TestCollection()
        {
            "TestCollection is never instantiated".Show();
        }
    }
}