using Xunit;

namespace WeakDictionary.WeakDictionaryContext
{
    public class WhenClearingDictionary : WeakDictionaryContext
    {
        public override void When()
        {
            dictionary.Clear( );
        }

        [Fact]
        public void ShouldBeEmpty()
        {
            Assert.Empty( dictionary );
        }
    }
}