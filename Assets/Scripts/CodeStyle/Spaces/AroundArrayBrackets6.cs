namespace CodeStyle.Spaces
{
    // Around Array Brackets
    public class AroundArrayBrackets6: Base
    {
        // Before array access brackets
        private void Foo1()
        {
            array[i] = array[i + 1];
        }
        // Before array rank brackets
        private void Foo2()
        {
            int[][,] x = null;
        }
        // Within array access brackets
        private void Foo3()
        {
            array[i] = array[i + 1];
        }
        // Within array rank brackets
        private void Foo4()
        {
            int[,] x = new int[1, 2];
        }
        // Within array rank empty brackets
        private void Foo5()
        {
            int[][,] x = null;
        }

    }
}