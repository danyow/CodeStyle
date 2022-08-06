using System;

namespace CodeStyle.Spaces
{
    // Within Parentheses in Statements
    public class WithinParenthesesInStatements4 : Base
    {
        // "if" parentheses
        private void Foo1()
        {
            if (condition)
            {
                foo();
            }
        }

        // "while" parentheses
        private void Foo2()
        {
            while (condition)
            {
                do
                {
                    foo();
                } while (condition);
            }
        }

        // ”catch" parentheses
        private void Foo3()
        {
            try
            {
                foo();
            }
            catch (Exception e)
            {
            }
            finally
            {
            }
        }

        // ”switch" parentheses
        private void Foo4()
        {
            switch (expression)
            {
                default:
                    break;
            }
        }

        // "for" parentheses
        private void Foo5()
        {
            for (int i = 0; i < 10; i++)
            {
                foo();
            }
        }

        // "foreach" parentheses
        private void Foo6()
        {
            foreach (object o in collection)
            {
                foo();
            }
        }

        // "using" parentheses
        private void Foo7()
        {
            using (C c = new C())
            {
                foo();
            }
        }

        // "lock" parentheses
        private void Foo8()
        {
            lock (this)
            {
                foo();
            }
        }

        // ”fixed" parentheses
        private unsafe void Foo9()
        {
            fixed (int* fib = new int[1])
            {
                foo();
            }
        }
    }
}