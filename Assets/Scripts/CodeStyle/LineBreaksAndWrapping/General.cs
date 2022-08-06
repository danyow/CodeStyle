namespace CodeStyle.LineBreaksAndWrapping
{
    public class General
    {
        private void KeepExistingLineBreaks()
        {
            var condition = Imitation.Value<bool>();
            
            var var = condition
                ? Imitation.Foo1()
                : Imitation.Foo2();
        }
        
        // Wrap long lines
        // When enabled:  
        // string output = string.Format(CultureInfo.InvariantCulture,
        //                               "{0:yyyy-MM-dd} {1}", date, message);
        // When disabled:
        // string output = string.Format(CultureInfo.InvariantCulture, "{0:yyyy-MM-dd} {1}", date, message);
        
        // Hard wrap at
        // This option (similarly to the Editorconfig's 'max_line_length') defines the desired maximum number of characters in each line.
        // It is applied during code reformatting if 'Wrap long lines' is enabled.
        // Line breaks are added, if possible, at the positions not exceeding the specified value,
        // according to the language syntax and other line wrapping settings.

        private void PreferWrapBefore()
        {
            var arg1 = Imitation.Value<int>();
            var arg2 = Imitation.Value<int>();
            var arg3 = Imitation.Value<int>();
            var arg4 = Imitation.Value<int>();
            var arg5 = Imitation.Value<int>();
            var arg6 = Imitation.Value<int>();
            var arg7 = Imitation.Value<int>();
            
            Imitation.Method(arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7);
        }

        private void PreferWrapBefore2()
        {
            var myObject = Imitation.Value<dynamic>();
            var someRatherLongExpression = Imitation.Value<dynamic>();
            myObject.ImportantField +=
                someRatherLongExpression;
        }


        private void SpecialElseIfTreatment()
        {
            var condition = Imitation.Value<bool>();
            if (condition)
            {
                Imitation.Foo1();
            }
            else if (condition)
            {
            }
        }
        
        class A
        {
        }
        
    }
}