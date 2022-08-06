namespace CodeStyle.Indents
{
    /// <summary>
    /// 嵌套语句
    /// </summary>
    public class NestedStatements
    {
        private void NestedUsing()
        {
            using (var a = new A())
            using (var b = new B())
            using (var c = new C())
            {
                Imitation.Foo1();
            }
        }


        private unsafe void NestedFixed()
        {
            var x = Imitation.Value<int[]>();

            fixed (int* a = x)
            fixed (int* b = x)
            fixed (int* c = x)
            {
                Imitation.Foo1();
            }
        }

        private void NestedLock()
        {
            var a = new object();
            var b = new object();
            var c = new object();

            lock (a)
            lock (b)
            lock (c)
            {
                Imitation.Foo1();
            }
        }

        private void NestedFor()
        {
            for (var a = 0; a < 1; a++)
            for (var b = 0; b < 2; b++)
            for (var c = 0; c < 3; c++)
            {
                Imitation.Foo1();
            }
        }

        private void NestedForeach()
        {
            var x = Imitation.Value<int[]>();
            var y = Imitation.Value<int[]>();
            var z = Imitation.Value<int[]>();
            foreach (var a in x)
            foreach (var b in y)
            foreach (var c in z)
            {
                Imitation.Foo1();
            }
        }

        private void NestedWhile()
        {
            var a = Imitation.Value<bool>();
            var b = Imitation.Value<bool>();
            var c = Imitation.Value<bool>();
            while (a)
            while (b)
            while (c)
            {
                Imitation.Foo1();
            }
        }

    }
}