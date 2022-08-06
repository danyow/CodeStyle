using System;
using System.Collections.Generic;

namespace CodeStyle.Spaces
{
    // Within Other Parentheses
    public class WithinOtherParentheses5 : Base
    {
        // Parentheses
        private void Foo1()
        {
            a = b * (c + d);
        }
        // Type cast parentheses
        private void Foo2()
        {
            int a = (int)b;
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
        // "typeof" parentheses
        private void Foo7()
        {
            Type t = typeof(bool);
        }
        // "default" parentheses
        private dynamic Foo8()
        {
            return default(int);
        }
        // "checked" and "unchecked" parentheses
        private dynamic Foo9()
        {
            return checked(100000 * 10000) + unchecked(10000 * 10000);
        }
        // "sizeof" parentheses
        private void Foo10()
        {
            int size = sizeof(bool);
        }
        // ”nameof" parentheses
        private dynamic Foo11()
        {
            return nameof(myField);
        }
        // ”new" parentheses
        private void Foo12()
        {
            List<int> x = new(5);
        }

    }
}