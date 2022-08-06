namespace CodeStyle.BlankLines
{
    public class AroundPropertyEventAccessor
    {
        public int X
        {
            get
            {
                Imitation.DoSomething();
                return 1;
            }
            set
            {
                Imitation.DoSomething();
                myField = value;
            }
        }

        private int myField;
    }
}