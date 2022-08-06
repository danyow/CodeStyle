using System;

namespace CodeStyle.LineBreaksAndWrapping
{
    public class ArrangementOfDeclarationBlocks
    {

        // Keep existing arrangement of declaration blocks
        interface I
        {
            int Property { get; set; }
        }

        interface I1
        {
            int Property { get; set; }
        }
        // Place abstract/auto property/indexer/event declaration on single line
        interface I2
        {
            int Property { get; set; }
        }
        // Place simple property/indexer/event declaration on single line
        class C
        {
            int Property { get { return x; } set { x = value; } }
            private dynamic x;
        }
        // Place it on single line even when it has attributes on accessors
        class C1
        {
            int Property
            {
                [Attr] get { return x; }
                [Attr] set { x = value; }
            }
            private dynamic x;
        }
        // Place simple accessor on single line 
        class C2
        {
            int Property
            {
                get { return x; }
                set
                {
                    if (value == null) throw new Exception();
                }
            }
            private dynamic x;
        }
        // Place simple method on single line 
        class C3
        {
            void Foo()
            {
                DoSomethingSimple();
            }

            private dynamic DoSomethingSimple;
        }
    }
}