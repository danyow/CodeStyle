namespace CodeStyle.LineBreaksAndWrapping
{
    public class EmbeddedStatements8: Base
    {
        // Keep existing arrangement of embedded statements
        private void P()
        {
            if (condition) DoSomething();
            if (condition1)
                DoSomething1();
        }
        // Place simple embedded statement on the same line
        private void P2()
        {
            if (condition)
                DoSomething();
            if (condition && // comment
                condition1)
                DoSomething();
        }
        // Place simple ”case” statement on the same line
        private dynamic P3()
        {
            switch (foo)
            {
                case 1:
                    return a;
                case 2:
                case 3:
                    return a;
            }
            return null;
        }
    }
}