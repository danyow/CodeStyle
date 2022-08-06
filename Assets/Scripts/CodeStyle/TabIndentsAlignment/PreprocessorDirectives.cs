// Indent #if #else #elif #endif （缩进 #if #else #elif #endif）
// Indent #if, #else, #elif, #endif

namespace N
{
    class A
    {
 #if !HideSomething
        int myField;
 #endif
    }
}

// Indent #region #endRegion （缩进 #regin #endRegion）
// Indent #region, #endregion
namespace N
{
    class B
    {

#region Fields
        int myField;
#endregion

    }
}

// Indent other preprocessor directives （缩进其他预处理器指令）
// Indent other preprocessor directives
namespace N
{
    class C
    {
#pragma warning disable CS3021
        int myField;
#warning Fixme
    }
}