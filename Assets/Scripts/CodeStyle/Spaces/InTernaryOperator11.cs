namespace CodeStyle.Spaces
{
    // In Ternary Operator
    public class InTernaryOperator11 : Base
    {
        // Before '?'
        private void Foo1()
        {
            bool b = condition
                ? expr1
                : expr2;
        }

        // After '?'
        private void Foo2()
        {
            bool b = condition
                ? expr1
                : expr2;
        }

        // Before ':'
        private void Foo3()
        {
            bool b = condition
                ? expr1
                : expr2;
        }

        // After :
        private void Foo4()
        {
            bool b = condition
                ? expr1
                : expr2;
        }
    }
}