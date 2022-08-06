using System.ComponentModel;

namespace CodeStyle.Spaces
{
    // Around Colon
    public class AroundColon13: Base
    {
        // Before base types list colon
        class Derived : BaseClass, IInterface
        {
        }
        // After base types list colon
        class Derived1 : BaseClass, IInterface
        {
        }
        // Before type parameter constraint colon
        class C<T1> where T1 : IInterface
        {
        }
        // After type parameter constraint colon
        // Before type parameter constraint colon
        class C1<T1> where T1 : IInterface
        {
        }
        // Before colon in "case" statement
        private void Foo5()
        {
            switch (expr)
            {
                case 0:
                    break;
            }
        }
        // After colon in "case" statement
        private dynamic Foo6()
        {
            switch (expr)
            {
                case 0: return a;
                case 1: return b;
            }

            return null;
        }
        // Before other colons
        [return: Description("returns A")] public A b1()
        {
            Method(arg1: 1, arg2: 3);
            var y = (tuple1: 1, tuple2: 2);
            return null;
        }
        // After other colons
        [return: Description("returns A")] public A b2()
        {
            Method(arg1: 1, arg2: 3);
            var y = (tuple1: 1, tuple2: 2);
            return null;
        }
    }
}