using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WeakDictionary
{
    public class WeakDictionary<TKey, TValue> : IDictionary<TKey, TValue> where TKey : class
    {
        private readonly IDictionary<WeakReference, TValue> data = new Dictionary<WeakReference, TValue>();

        private IEnumerable<KeyValuePair<TKey, TValue>> GetValues()
        {
            return ( from item in data select new KeyValuePair<TKey, TValue>( item.Key.Target as TKey, item.Value ) );
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator( )
        {
            return GetValues( ).GetEnumerator( );
        }

        IEnumerator IEnumerable.GetEnumerator( )
        {
            return GetValues( ).GetEnumerator( );
        }

        public void Add( KeyValuePair<TKey, TValue> item )
        {
            throw new NotImplementedException( );
        }

        public void Clear( )
        {
            throw new NotImplementedException( );
        }

        public bool Contains( KeyValuePair<TKey, TValue> item )
        {
            throw new NotImplementedException( );
        }

        public void CopyTo( KeyValuePair<TKey, TValue>[] array, int arrayIndex )
        {
            throw new NotImplementedException( );
        }

        public bool Remove( KeyValuePair<TKey, TValue> item )
        {
            throw new NotImplementedException( );
        }

        public int Count
        {
            get { return GetValues( ).Count( ); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool ContainsKey( TKey key )
        {
            throw new NotImplementedException( );
        }

        public void Add( TKey key, TValue value )
        {
            var reference = new WeakReference( key );
            data.Add( reference, value );
        }

        public bool Remove( TKey key )
        {
            throw new NotImplementedException( );
        }

        public bool TryGetValue( TKey key, out TValue value )
        {
            throw new NotImplementedException( );
        }

        public TValue this[ TKey key ]
        {
            get { throw new NotImplementedException( ); }
            set { throw new NotImplementedException( ); }
        }

        public ICollection<TKey> Keys
        {
            get { throw new NotImplementedException( ); }
        }

        public ICollection<TValue> Values
        {
            get { throw new NotImplementedException( ); }
        }
    }
}
