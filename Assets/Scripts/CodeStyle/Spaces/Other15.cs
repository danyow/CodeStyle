using System;
using X = CodeStyle.Base.A.B;


namespace CodeStyle.Spaces
{
    // Other
    public class Other15 : Base
    {


        // After type cast parentheses
        private void Foo1()
        {
            int a = (int)b;
        }

        // Around dot
        private void Foo2()
        {
            a.b.foo();
        }

        // Around lambda arrow
        private void Foo3()
        {
            Func<int, int> a = x => x + 1;
        }

        // Before unsafe pointer declaration
        private unsafe void Foo4()
        {
            int* x;
        }

        // Before nullable mark
        private void Foo5()
        {
            int? i = null;
        }

        // Around '=' in namespace alias directive
        private void Foo6()
        {
            // Header
        }

        // Before end of line comment
        private void Foo7()
        {
            var x = 4; // x = 4
        }

        // After operator keyword
        public static bool operator ==(Other15 x, C y)
        {
            return false;
        }

        public static bool operator !=(Other15 x, C y)
        {
            return false;
        }


    }
}