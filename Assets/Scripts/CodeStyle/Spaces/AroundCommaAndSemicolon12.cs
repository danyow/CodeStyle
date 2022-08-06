namespace CodeStyle.Spaces
{
    // Around Comma and Semicolon 
    public class AroundCommaAndSemicolon12 : Base
    {
        // Before comma
        private void Foo1()
        {
            foo(a, b, c);
        }

        // After comma
        private void Foo2()
        {
            foo(a, b, c);
        }

        // Before "for" semicolon
        private void Foo3()
        {
            for (int i = 1; i < 10; i++)
            {
            }
        }

        // After "for" semicolon
        private void Foo4()
        {
            for (int i = 1; i < 10; i++)
            {
            }
        }

        // Before semicolon
        private void Foo5()
        {
            a = b;
        }
    }
}