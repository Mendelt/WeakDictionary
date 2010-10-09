﻿using Xunit;

namespace WeakDictionary.WeakDictionaryContext
{
    public class WhenItemIsAdded : WeakDictionaryContext
    {
        [Fact]
        public void DictionaryShouldContainTwoItems()
        {
            Assert.Equal( 1, dictionary.Count );
        }

        [Fact]
        public void ItemShouldBeInDictionary()
        {
            Assert.Equal(value1, dictionary[key1]);
        }

        [Fact]
        public void ValuesShouldContainItemValue()
        {
            Assert.True( dictionary.Values.Contains( value1 ) );
        }

        [Fact]
        public void KeysShouldContainItemKey()
        {
            Assert.True( dictionary.Keys.Contains( key1 ) );
        }

        [Fact]
        public void TryGetItemShouldReturnItem()
        {
            object item;

            dictionary.TryGetValue( key1, out item );
            Assert.Equal( value1, item );
        }
    }
}
