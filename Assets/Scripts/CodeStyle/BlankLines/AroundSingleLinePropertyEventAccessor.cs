namespace CodeStyle.BlankLines
{
    public class AroundSingleLinePropertyEventAccessor
    {
        public int X { get { return 1; } set { myField = value; } }
        
        private int myField;
    }
}