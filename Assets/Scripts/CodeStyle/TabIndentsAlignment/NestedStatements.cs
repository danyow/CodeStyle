namespace CodeStyle.TabIndentsAlignment
{
    /// <summary>
    /// 嵌套语句
    /// </summary>
    public class NestedStatements : Base
    {
        // Indent nested "using" statements 
        private void NestedUsing()
        {
            using (A a = new A())
            using (B b = new B())
            using (C c = new C())
            {
                foo();
            }
        }

        // Indent nested "fixed" statements
        private unsafe void NestedFixed()
        {
            var x = Value<int[]>();
            var y = Value<int[]>();
            var z = Value<int[]>();

            fixed (int* a = x)
            fixed (int* b = y)
            fixed (int* c = z)
            {
                foo();
            }
        }

        // Indent nested "lock" statements
        private void NestedLock()
        {
            lock (a)
            lock (b)
            lock (c)
            {
                foo();
            }
        }

        // Indent nested "for" statements
        private void NestedFor()
        {
            for (int a = 0; a < x; a++)
            for (int b = 0; b < y; b++)
            for (int c = 0; c < y; c++)
            {
                foo();
            }
        }

        // Indent nested "foreach" statements
        private void NestedForeach()
        {
            foreach (var a in x)
            foreach (var b in y)
            foreach (var c in z)
            {
                foo();
            }
        }

        // Indent nested "while”statements
        private void NestedWhile()
        {
            while (a)
            while (b)
            while (c)
            {
                foo();
            }
        }

    }
}