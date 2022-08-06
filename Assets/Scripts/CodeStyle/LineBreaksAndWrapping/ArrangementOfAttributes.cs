using UnityEngine;

namespace CodeStyle.LineBreaksAndWrapping
{
    public class ArrangementOfAttributes
    {
        // Place attribute section list on separate line if it is longer than
        // Attribute sections longer than specified values would be placed on separate line

        // Keep exiting arrangement of attributes
        [Attribute]
        class C { }

        [Attribute] class C1 { }
        
        // Place type attribute on the same line
        [Attribute]
        class C2 { }

        [Attribute]
        class C3
        {
            // comment 
        }
        
        // Place method attribute on the same line
        interface I
        {
            [Attribute]
            void foo();
        }

        class C4
        {
            [Attribute]
            void foo()
            {
                // comment
            }
        }
        
        // Place property/indexer/event attribute on the same line
        
        interface I2
        {
            [Attribute] int Property { get; }
        }

        class C5
        {
            [Attribute]
            int Property
            {
                get
                {
                    // comment
                    return 0;
                }
            }
        }
        
        // Place accessor attribute on the same line
        interface I3
        {
            int Property { [Attribute] get; }
        }

        class C6
        {
            int Property
            {
                [Attribute] get { return x; }
                [Attribute]
                set
                {
                    x = value;
                    Imitation.Foo1();
                }
            }

            private int x;
        }
        
        // Place field attribute on the same line
        class C7
        {
            [Attribute]
            int x;

            [Attribute]
            dynamic y = // comment 
                new Object();
        }
    }
}