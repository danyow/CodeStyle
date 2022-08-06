namespace CodeStyle.Spaces
{
    // Around Binary Operators
    public class AroundBinaryOperators9: Base
    {
        
        // Assignment operators (=+....
        private void Foo1()
        {
            int[] x = new int[]
            {
                0,
                1,
                2
            };
        } 
        // Logical operators (&,|)
        private void Foo2()
        {
            if (a && b || c)
            {
            }
        }
        // Equality operators (==,!=)
        private void Foo3()
        {
            if (a == b)
            {
            }
        }
        // Relational operators (<,>,<=,>=)
        private void Foo4()
        {
            bool condition = a < b;
        }
        // Bitwise operators (&,I,^)
        private void Foo5()
        {
            bool condition = a < b;
        } 
        // Additive operators (+,-)
        private void Foo6()
        {
            bool condition = a < b;
        }
        // Mutiplicative operators (*./,%)
        private void Foo7()
        {
            a = a * b / c;
        }
        // Shift operators(<<,>>)
        private void Foo8()
        {
            x = x << 1;
        }
        // Null coalescing operator (??)
        private void Foo9()
        {
            x = a ?? b;
        }
        // Unsafe arrow operator (->)
        private unsafe void Foo10()
        {
            int* ptr = null;
            int b = ptr->GetHashCode();
        }
    }
}