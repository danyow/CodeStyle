using System;

namespace CodeStyle.Spaces
{
    // Around Braces
    public class AroundBraces8 : Base
    {

        // Before single line accessors block
        int Property { get; set; }

        // Within single line accessor
        int Property1 { get { return x; } set { x = value; } }

        // Between accessors in single line property/event
        int Property2 { get; set; }

        // Space between empty braces
        class C
        {
        }

        // Within single line method
        void Foo()
        {
            DoSomething();
        }

        // Within single line anonymous method
        EventHandler e = delegate { return; };

        // Within single -line expression braces
        private void Foo7()
        {
            int[] x = new int[]
            {
                0,
                1,
                2
            };
        }

    }
}