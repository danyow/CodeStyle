using System.Collections.Generic;
using JetBrains.Annotations;

namespace CodeStyle.Spaces
{
    // Attributes
    public class Attributes14 : Base
    {
        // Between attribute sections
        private interface IFoo1
        {
            void Method([NotNull] [ItemNotNull] IList<string> items);
        }

        // Within attribute brackets
        [Attr1, Attr2(true)] class C
        {
        }

        // After attributes
        private interface IFoo2
        {
            void Method([NotNull] [ItemNotNull] IList<string> items);
        }
    }
}