namespace CodeStyle.LineBreaksAndWrapping
{
    // Arrangement of Interpolated Strings
    // 插值串的排列
    public class InterpolatedStrings18 : Base
    {
        // Wrap verbatim interpolated strings 
        // 换行逐字插值字符串
        private void Foo1()
        {
            var s =
                $@"id={id} src={src} dest={dest}";
        }

    }
}