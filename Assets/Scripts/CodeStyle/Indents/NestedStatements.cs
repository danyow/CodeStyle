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
                Fake.Foo1();
            }
        }


        private unsafe void NestedFixed()
        {
            var x = Fake.Array();

            fixed (int* a = x)
            fixed (int* b = x)
            fixed (int* c = x)
            {
                Fake.Foo1();
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
                Fake.Foo1();
            }
        }

        private void NestedFor()
        {
            for (var a = 0; a < 1; a++)
            for (var b = 0; b < 2; b++)
            for (var c = 0; c < 3; c++)
            {
                Fake.Foo1();
            }
        }

        private void NestedForeach()
        {
            var x = Fake.Array();
            var y = Fake.Array();
            var z = Fake.Array();
            foreach (var a in x)
            foreach (var b in y)
            foreach (var c in z)
            {
                Fake.Foo1();
            }
        }

        private void NestedWhile()
        {
            var a = Fake.Boolean();
            var b = Fake.Boolean();
            var c = Fake.Boolean();
            while (a)
            while (b)
            while (c)
            {
                Fake.Foo1();
            }
        }

    }
}