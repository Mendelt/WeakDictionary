using System;
using TestHelpers;
using Xunit;

namespace WeakDictionary.WeakDictionaryContext
{
    public class WeakDictionaryContext : ContextBase
    { }

    public class WhenDeletingKey : WeakDictionaryContext
    {
        public WeakDictionary<object, object> dictionary = new WeakDictionary<object, object>( );

        private object key = new object( );
        private object value = new object( );

        public override void Given( )
        {
            dictionary.Add( key, value );
            key = null;
            GC.Collect( );
        }

    }

    public class WhenAddingItem : WeakDictionaryContext
    {
        public WeakDictionary<object, object> dictionary = new WeakDictionary<object, object>( );

        object key = new object(  );
        object item = new object(  );

        public override void Given()
        {
            dictionary.Add(key, item);
        }

        [Fact]
        public void DictionaryShouldContainOneItem()
        {
            Assert.Equal( 1, dictionary.Count );
        }

        [Fact]
        public void ItemShouldBeInDictionary()
        {
            Assert.Equal(item, dictionary[key]);
        }
    }
}
