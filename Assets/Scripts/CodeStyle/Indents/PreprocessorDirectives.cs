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
    class C
    {

#if !HideSomething
        int myField;
#endif

    }
}

// Indent #region #endRegion （缩进 #regin #endRegion）
namespace N
{
    class D
    {

#region Fields
        int myField;
#endregion

    }
}

// Indent other preprocessor directives （缩进其他预处理器指令）
namespace N
{
    class E
    {
        
#pragma warning disable CS3021
        int myField;
#warning Fixme
        
    }
}