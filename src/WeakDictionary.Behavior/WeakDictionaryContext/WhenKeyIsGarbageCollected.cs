using System;
using Xunit;

namespace WeakDictionary.WeakDictionaryContext
{
    public class WhenKeyIsGarbageCollected : WeakDictionaryContext
    {
        public override void When( )
        {
            key1 = null;
            GC.Collect( );
        }

        [Fact]
        public void DictionaryShouldNotContainItem()
        {
            Assert.False( dictionary.Values.Contains( value1 ));
        }

        [Fact]
        public void DictionaryShouldStillContainOtherItem()
        {
            Assert.True( dictionary.Values.Contains( value2 ) );
        }
    }
}