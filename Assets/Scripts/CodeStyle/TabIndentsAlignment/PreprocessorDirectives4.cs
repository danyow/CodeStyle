// ReSharper disable InconsistentNaming
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable UnusedType.Global
#pragma warning disable CS1030

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