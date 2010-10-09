using System;
using Xunit;

namespace WeakDictionary.WeakReferenceContext
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
}