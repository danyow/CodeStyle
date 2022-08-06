namespace CodeStyle.BlankLines
{
    public class AroundSingleLineLocalFunction
    {
        private void Method()
        {
            void LocalFunction1() { }
            void LocalFunction2() { }
        }
    }
}