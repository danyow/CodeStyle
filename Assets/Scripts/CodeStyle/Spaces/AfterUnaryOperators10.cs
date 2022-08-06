namespace CodeStyle.Spaces
{
    // After Unary Operators
    public class AfterUnaryOperators10: Base
    {
        // Logical not operator (!)
        private void Foo1()
        {
            if (!x) return;
        }
        // Unary minus operator (-)
        private void Foo2()
        {
            int x = -5;
        }
        // Unary plus operator (+)
        private void Foo3()
        {
            int x = +5;
        }
        // Unsafe addressof operator (&)
        private unsafe void Foo4()
        {
            int p = 1;
            int* b = &p;
        }
        // Unsafe asterisk operator (*)
        private unsafe void Foo5()
        {
            int* ptr = null;
            int p = *ptr;
        }
        // Before/after ++ and --
        void Method(int p)
        {
            p++;
            --p;
        }

    }
}