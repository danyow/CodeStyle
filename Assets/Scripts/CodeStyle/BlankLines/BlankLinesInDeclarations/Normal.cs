namespace CodeStyle.BlankLines.BlankLinesInDeclarations
{
    

    
    public class Normal: Base
    {
        // Keep max blank lines in declarations 
        class C
        {
            void Method1()
            {
            }


            void Method2()
            {
            }
        }
        
        // Remove blank lines after "{" and before "}" in declarations
        class D
        {

            void Method1()
            {
            }

            void Method2()
            {
            }

        }
        
        // Around type
        class C3
        {
            int a;
        }

        class C4
        {
            int a;
        }

        class C5
        {
            int a;
        }

        // Around single -line type
        delegate int MyDelegate(int a);

        delegate int MyDelegate2(int a);

        delegate int MyDelegate3(int a);

        // Inside type
        class C6
        {
            int x;
            int y;
        }

        // Around field
        class C8
        {
            /// <summary>x description</summary>
            int x;

            /// <summary>y description</summary>
            int y;
        }

        // Around single line field
        class C9
        {
            int x;
            int y;
        }

        // Around property/event
        class C10
        {
            /// <summary>x description</summary>
            public int X { get { return 1; } }

            /// <summary>y description</summary>
            public int Y { get { return 2; } }
        }

        // Around single line property/event
        class C11
        {
            public int X { get { return 1; } }
            public int Y { get { return 2; } }
        }

        // Around auto/abstract property/event
        class C12
        {
            /// <summary>x description</summary>
            public int X { get; set; }

            /// <summary>x description</summary>
            public int Y { get; set; }
        }

        // Around single line auto/ abstract property/event 
        class C13
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        // Around property/event accessor
        class C14
        {
            public int X
            {
                get
                {
                    DoSomething();
                    return 1;
                }
                set
                {
                    DoSomething();
                    myField = value;
                }
            }
        }
        
        // Around single line property/event accessor
        class C15
        {
            public int X { get { return 1; } set { myField = value; } }
        }
        
        // Around method
        class C16
        {
            void Method1()
            {
                foo();
                foo2();
            }

            void Method2()
            {
                foo();
                foo2();
            }
        }
        
        // Around single line method
        abstract class C17
        {
            protected abstract void Method1();
            protected abstract void Method2();
        }
    }
}

// Around namespace
namespace N1
{
}

namespace N2
{
}

// Inside namespace
namespace N1
{
    class C1
    {
    }

    class C2
    {
    }
}

// After file- scoped namespace directive
// namespace N1;

class C1
{
}

class C2
{
}

class C3
{
}

class C4
{
}

class C5
{
}

