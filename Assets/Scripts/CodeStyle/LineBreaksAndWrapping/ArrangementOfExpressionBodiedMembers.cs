using System;

namespace CodeStyle.LineBreaksAndWrapping
{
    public class ArrangementOfExpressionBodiedMembers
    {
        // Keep existing arrangement of expression bodied members
        class A
        {
            public int Foo() => 0;

            public int Foo1()
                => 1;

            public int Foo2() =>
                2;
        }
        
        
        // Place method expression body on the same line
        class B
        {
            public int Foo() => 0;

            public int // comment
                Foo1() =>
                1;

            public int Foo2() =>
                1 + // comment
                2;
        }
        // Place property expression body on the same line
        class C
        {
            public int Foo => 0;

            public int // comment
                Foo1 => 1;

            public int Foo2 => 1 + // comment
                               2;
        }
        // Place property accessor expression body on the same line
        class D
        {
            public int Foo { get => 0; }

            public int Foo1
            {
                get =>
                    1 + // comment
                    2;
            }
        }
        // Prefer wrap before "=>" followed by expressions
        class E
        {
            public int Foo(int y) =>
                Br(y * y + y << y + y);

            Func<int, int, int>
                Method2()
            {
                return (xxx, yyy) =>
                    Br(xxx * yyy);
            }

            private dynamic Br;
        }
    }
}