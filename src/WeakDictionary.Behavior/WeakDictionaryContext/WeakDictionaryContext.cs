using TestHelpers;

namespace WeakDictionary.WeakDictionaryContext
{
    public class WeakDictionaryContext : ContextBase
    {
        public WeakDictionary<object, object> dictionary = new WeakDictionary<object, object>();

        public override void Given()
        {
            dictionary = new WeakDictionary<object, object>
            {
                {key1, value1}, 
                {key2, value2}
            };
        }

        protected object key1 = new object( );
        protected object key2 = new object( );
        
        protected object value1 = new object( );
        protected object value2 = new object( );
    }
}