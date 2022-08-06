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

namespace CodeStyle.Spaces
{
    // Around Binary Operators
    public class AroundBinaryOperators9 : Base
    {

        // Assignment operators (=+....
        private void Foo1()
        {
            int[] x = new int[]
            {
                0,
                1,
                2
            };
        }

        // Logical operators (&,|)
        private void Foo2()
        {
            if (a && b || c)
            {
            }
        }

        // Equality operators (==,!=)
        private void Foo3()
        {
            if (a == b)
            {
            }
        }

        // Relational operators (<,>,<=,>=)
        private void Foo4()
        {
            bool condition = a < b;
        }

        // Bitwise operators (&,I,^)
        private void Foo5()
        {
            bool condition = a < b;
        }

        // Additive operators (+,-)
        private void Foo6()
        {
            bool condition = a < b;
        }

        // Mutiplicative operators (*./,%)
        private void Foo7()
        {
            a = a * b / c;
        }

        // Shift operators(<<,>>)
        private void Foo8()
        {
            x = x << 1;
        }

        // Null coalescing operator (??)
        private void Foo9()
        {
            x = a ?? b;
        }

        // Unsafe arrow operator (->)
        private unsafe void Foo10()
        {
            int* ptr = null;
            int b = ptr->GetHashCode();
        }
    }
}