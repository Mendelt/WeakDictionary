using System;
using Xunit;

namespace WeakDictionary.WeakDictionaryContext
{
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
        public void ItemShouldBeInDictionary()
        {
            Assert.Equal(item, dictionary[key]);
        }
    }
}
