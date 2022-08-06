namespace CodeStyle.Indents
{
    public class General : Base
    {
        public void P()
        {

            // Indent style
            // Indent size
            // Tab width
            if (condition)
            {
                if (condition1)
                {
                    foo1();
                    foo2();
                }
                else
                {
                    foo3();
                    foo4();
                }
            }

            // Continuous line indent multiplier
            int x = foo1() +
                    foo2();
        }
    }
}