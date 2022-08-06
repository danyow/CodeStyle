using System;
using System.Collections.Generic;

namespace CodeStyle.Spaces
{
    // Before Other Parentheses
    public class BeforeOtherParentheses3 : Base
    {
        // Method call parentheses
        void Method()
        {
            foo1("string", true);
            foo2();
        }

        // Method call empty parentheses
        void Method1()
        {
            foo1("string", true);
            foo2();
        }

        // Method declaration parentheses
        abstract class C
        {
            public abstract void Method1(string str);
            public abstract void Method2();
        }

        // Method declaration empty parentheses
        abstract class C1
        {
            public abstract void Method1(string str);
            public abstract void Method2();
        }

        // "typeof" parentheses
        private void Foo5()
        {
            Type t = typeof(bool);
        }

        // ”default" parentheses
        private int Foo6()
        {
            return default(int);
        }

        // "checked" and "unchecked" parentheses
        private int Foo7()
        {
            return checked(100000 * 10000) + unchecked(10000 * 10000);
        }

        // ”sizeof" parentheses
        private void Foo8()
        {
            int size = sizeof(bool);
        }

        // "nameof" parentheses
        private dynamic Foo9()
        {
            return nameof(myField);
        }

        // "new" parentheses
        private void Foo10()
        {
            List<int> x = new();
        }

        // Between keyword and expression
        public SomeType A(object a)
        {
            return (SomeType)a ?? throw (new Exception());
        }

        // Between keyword and type
        public (int, int) A(ref (int, int) a)
        {
            return a;
        }

    }
}