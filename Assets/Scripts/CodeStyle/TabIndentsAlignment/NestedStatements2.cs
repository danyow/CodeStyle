// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable LocalVariableHidesMember
// ReSharper disable UnusedVariable
// ReSharper disable UnusedMember.Local
// ReSharper disable ConvertToUsingDeclaration
// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable SuggestVarOrType_BuiltInTypes

namespace CodeStyle.TabIndentsAlignment
{
    [Settings(@"Nested Statements")]
    [Tanslate(@"嵌套语句")]
    public class NestedStatements2 : Base
    {
        [Settings(@"Indent nested ""using"" statements")]
        private void NestedUsing()
        {
            using (A a = new A())
            using (B b = new B())
            using (C c = new C())
            {
                foo();
            }
        }

        [Settings(@"Indent nested ""fixed"" statements")]
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

        [Settings(@"Indent nested ""lock"" statements")]
        private void NestedLock()
        {
            lock (a)
            lock (b)
            lock (c)
            {
                foo();
            }
        }

        [Settings(@"Indent nested ""for"" statements")]
        private void NestedFor()
        {
            for (int a = 0; a < x; a++)
            for (int b = 0; b < y; b++)
            for (int c = 0; c < y; c++)
            {
                foo();
            }
        }

        [Settings(@"Indent nested ""foreach"" statements")]
        private void NestedForeach()
        {
            foreach (var a in x)
            foreach (var b in y)
            foreach (var c in z)
            {
                foo();
            }
        }

        [Settings(@"Indent nested ""while"" statements")]
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