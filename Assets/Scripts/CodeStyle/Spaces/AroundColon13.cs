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
// ReSharper disable EmptyGeneralCatchClause
// ReSharper disable RedundantEmptyFinallyBlock
// ReSharper disable RedundantEmptySwitchSection
// ReSharper disable ExpressionIsAlwaysNull

#pragma warning disable CS0414
#pragma warning disable CS8509
#pragma warning disable CS0108, CS0114
#pragma warning disable CS8321
#pragma warning disable CS0219
#pragma warning disable CS0693
#pragma warning disable CS0472
#pragma warning disable CS0168


using System.ComponentModel;

namespace CodeStyle.Spaces
{
    // Around Colon
    public class AroundColon13 : Base
    {
        // Before base types list colon
        class Derived : BaseClass, IInterface
        {
        }

        // After base types list colon
        class Derived1 : BaseClass, IInterface
        {
        }

        // Before type parameter constraint colon
        class C<T1> where T1 : IInterface
        {
        }

        // After type parameter constraint colon
        // Before type parameter constraint colon
        class C1<T1> where T1 : IInterface
        {
        }

        // Before colon in "case" statement
        private void Foo5()
        {
            switch (expr)
            {
                case 0:
                    break;
            }
        }

        // After colon in "case" statement
        private dynamic Foo6()
        {
            switch (expr)
            {
                case 0: return a;
                case 1: return b;
            }

            return null;
        }

        // Before other colons
        [return: Description("returns A")] public A b1()
        {
            Method(arg1: 1, arg2: 3);
            var y = (tuple1: 1, tuple2: 2);
            return null;
        }

        // After other colons
        [return: Description("returns A")] public A b2()
        {
            Method(arg1: 1, arg2: 3);
            var y = (tuple1: 1, tuple2: 2);
            return null;
        }
    }
}