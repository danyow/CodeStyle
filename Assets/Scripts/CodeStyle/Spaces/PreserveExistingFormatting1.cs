namespace CodeStyle.Spaces
{
    // Preserve Existing Formatting
    public class PreserveExistingFormatting1: Base
    {
        // Extra spaces inside
        private void Foo1()
        {
            var x = foo(5);
            var xx = foo(5 + 6);
            var xxx = foo(5 + 6 + 7);
            var tab = foo(5);
            var tabx = foo(5 + 6);
            var tabxx = foo(5 + 6 + 7);
        }
    }
}