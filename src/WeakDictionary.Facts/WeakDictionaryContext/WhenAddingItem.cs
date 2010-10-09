using System;
using Xunit;

namespace WeakDictionary.WeakDictionaryContext
{
    public class WhenDeletingKey
    {
        public WeakDictionary<object, object> dictionary = new WeakDictionary<object, object>( );

        private object key = new object( );
        private object value = new object( );

        public WhenDeletingKey()
        {
            dictionary.Add( key, value );
            key = null;
            GC.Collect();
        }

    }

    public class WhenAddingItem
    {
        public WeakDictionary<object, object> dictionary = new WeakDictionary<object, object>( );

        object key = new object(  );
        object item = new object(  );

        public WhenAddingItem()
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
