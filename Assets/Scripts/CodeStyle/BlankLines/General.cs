// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable LocalVariableHidesMember
// ReSharper disable UnusedVariable
// ReSharper disable UnusedMember.Local
// ReSharper disable ConvertToUsingDeclaration
// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable InconsistentNaming
// ReSharper disable ParameterHidesMember
// ReSharper disable UnusedParameter.Local
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable UnusedType.Local
// ReSharper disable EmptyForStatement
// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable UnusedTypeParameter
// ReSharper disable TailRecursiveCall
// ReSharper disable FunctionRecursiveOnAllPaths
// ReSharper disable BuiltInTypeReferenceStyle
// ReSharper disable StringLiteralTypo
// ReSharper disable IdentifierTypo
// ReSharper disable UnassignedGetOnlyAutoProperty
// ReSharper disable UnusedParameter.Global
// ReSharper disable UnusedAnonymousMethodSignature
// ReSharper disable ArrangeAccessorOwnerBody
// ReSharper disable ValueParameterNotUsed
// ReSharper disable RedundantArrayCreationExpression
// ReSharper disable RedundantExplicitArrayCreation
// ReSharper disable ArrangeTrailingCommaInMultilineLists
// ReSharper disable LocalFunctionHidesMethod

#pragma warning disable CS0414
#pragma warning disable CS8509
#pragma warning disable CS0108, CS0114
#pragma warning disable CS8321
#pragma warning disable CS0219

// 空行

namespace CodeStyle.BlankLines
{
    /// <summary>
    /// 通常
    /// </summary>
    public class General : Base
    {
        // Around region（region外面） -> 0
        // Inside region（region里面） -> 1

        abstract class C
        {
            protected abstract void Method1();

#region Region Description
            protected abstract void Method2();
#endregion

            protected abstract void Method3();
        }

        // Before single-line comment（单行注释前） -> 0
        private void Foo()
        {
            void Foo()
            {
                var x = 5;
                // comment
                Call();
                ////CommentedCall();
            }
        }
    }
}