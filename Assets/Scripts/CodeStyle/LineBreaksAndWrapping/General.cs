namespace CodeStyle.LineBreaksAndWrapping
{
    public class General : Base
    {
        // Keep existing line breaks

        private void KeepExistingLineBreaks()
        {
            int var = condition
                ? SomeFunc1()
                : SomeFunc2();
        }
        
        // Wrap long lines
        // Wrap long lines
        // When enabled:  
        // string output = string.Format(CultureInfo.InvariantCulture,
        //                               "{0:yyyy-MM-dd} {1}", date, message);
        // When disabled:
        // string output = string.Format(CultureInfo.InvariantCulture, "{0:yyyy-MM-dd} {1}", date, message);
        
        // Hard wrap at
        // Hard wrap at
        // This option (similarly to the Editorconfig's 'max_line_length') defines the desired maximum number of characters in each line.
        // It is applied during code reformatting if 'Wrap long lines' is enabled.
        // Line breaks are added, if possible, at the positions not exceeding the specified value,
        // according to the language syntax and other line wrapping settings.

        // Prefer wrap before
        private void PreferWrapBefore()
        {
            CallMethod(arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7);
        }

        // Prefer wrap before"
        private void PreferWrapBefore2()
        {
            myObject.ImportantField +=
                someRatherLongExpression;
        }


        // Special”else if" treatment
        private void SpecialElseIfTreatment()
        {
            if (condition)
            {
                foo();
            }
            else if (condition)
            {
            }
        }
        
        // Line feed at end of file
        class A
        {
        }
        
    }
}
