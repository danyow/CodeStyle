namespace CodeStyle.BlankLines
{
    public class AroundLocalFunction
    {
        private void Method()
        {
            void LocalFunction1()
            {
                Imitation.Foo1();
                Imitation.Foo1();
            }

            void LocalFunction2()
            {
                Imitation.Foo1();
                Imitation.Foo1();
            }
        }
    }
}