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
// ReSharper disable EmptyNamespace
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable CommentTypo
// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable EmptyConstructor
// ReSharper disable HeuristicUnreachableCode
// ReSharper disable RedundantJumpStatement
// ReSharper disable ObjectCreationAsStatement
// ReSharper disable RedundantEmptyObjectCreationArgumentList

#pragma warning disable CS0414
#pragma warning disable CS8509
#pragma warning disable CS0108, CS0114
#pragma warning disable CS8321
#pragma warning disable CS0219
#pragma warning disable CS0693
#pragma warning disable CS0472
#pragma warning disable CS0168

namespace CodeStyle.LineBreaksAndWrapping
{
    // Arrangement of Invocations
    // 调用安排
    public class Invocations13 : Base
    {
        // Wrap invocation arguments
        // 包装调用参数
        private void Foo1()
        {
            CallMethod(arg1, arg2);
            CallMethod(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5
            );
        }

        // Max invocation arguments on a single line
        // 单行上的最大调用参数
        private void Foo2()
        {
            CallMethod(arg1);
            CallMethod(arg1, arg2);
            CallMethod(arg1, arg2, arg3);
            CallMethod(arg1, arg2, arg3, arg4);
            CallMethod(arg1, arg2, arg3, arg4, arg5);
            CallMethod(arg1, arg2, arg3, arg4, arg5, arg6);
            CallMethod(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            CallMethod(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            CallMethod(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        // Keep existing arrangement of parenthesis in invocation
        // 将括号的现有安排保留在调用中
        private void Foo3()
        {
            CallMethod(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5
            );
        }

        // Prefer wrap before "(" in invocation
        // 在调用中，更喜欢在“(”)之前换行
        // Prefer wrap after "(" in invocation
        // 更喜欢在调用中的“(”)后面换行
        // Prefer wrap before ")" in invocation
        // 在调用中更喜欢在“)”之前换行
        private void Foo4()
        {
            CallMethod(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5
            );
        }
    }
}