using System;
using Xunit;

namespace WeakDictionary
{
    public class WeakReferenceTest
    {
        [Fact]
        public void Test()
        {
            var obj = new object( );
            var reference = new WeakReference(obj);
            Assert.True( reference.IsAlive );
            obj = null;
            GC.Collect();
            Assert.False( reference.IsAlive );
        }
    }

    public class ContextBase : IDisposable
    {
        public ContextBase()
        {
            try { Context(); }
            catch (Exception ex) { Console.Write(ex.ToString()); }

            try { When(); }
            catch (Exception ex) { Throws = ex; }
        }

        public void Dispose()
        {
            CleanUp( );
        }

        protected Exception Throws { get; private set; }

        public virtual void Context() { }
        public virtual void When() { }
        public virtual void CleanUp() { }
    }

    public class WhenAddingItem
    {
        public WeakDictionary<string, string> dictionary = new WeakDictionary<string, string>( );

        public WhenAddingItem()
        {
            
        }

        [Fact]
        public void ItemShouldBeInDictionary()
        {
            throw new NotImplementedException();
        }
    }
}
