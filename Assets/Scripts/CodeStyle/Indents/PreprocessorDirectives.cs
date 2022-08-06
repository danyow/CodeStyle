namespace CodeStyle.Indents
{
    /// <summary>
    /// 预处理器指令
    /// </summary>
    public class PreprocessorDirectives
    {

    }
}

// Indent #if #else #elif #endif （缩进 #if #else #elif #endif）
namespace N
{
    class A
    {

#if !HideSomething
        private int _myField;
#endif

    }
}

// Indent #region #endRegion （缩进 #regin #endRegion）
namespace N
{
    class B
    {

#region Fields
        private int _myField;
#endregion

    }
}

// Indent other preprocessor directives （缩进其他预处理器指令）
namespace N
{
    class C
    {

#pragma warning disable CS3021
        private int _myField;
#warning Fixme

    }
}