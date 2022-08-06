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

#pragma warning disable CS0414
#pragma warning disable CS8509
#pragma warning disable CS0108, CS0114
#pragma warning disable CS8321
#pragma warning disable CS0219

using System;

namespace CodeStyle.LineBreaksAndWrapping
{
    public class ExpressionBodiedMembers3
    {
        // Keep existing arrangement of expression bodied members
        class A
        {
            public int Foo() => 0;

            public int Foo1()
                => 1;

            public int Foo2() =>
                2;
        }


        // Place method expression body on the same line
        class B
        {
            public int Foo() => 0;

            public int // comment
                Foo1() =>
                1;

            public int Foo2() =>
                1 + // comment
                2;
        }

        // Place property expression body on the same line
        class C
        {
            public int Foo => 0;

            public int // comment
                Foo1 => 1;

            public int Foo2 => 1 + // comment
                               2;
        }

        // Place property accessor expression body on the same line
        class D
        {
            public int Foo { get => 0; }

            public int Foo1
            {
                get =>
                    1 + // comment
                    2;
            }
        }

        // Prefer wrap before "=>" followed by expressions
        class E
        {
            public int Foo(int y) =>
                Br(y * y + y << y + y);

            Func<int, int, int>
                Method2()
            {
                return (xxx, yyy) =>
                    Br(xxx * yyy);
            }

            private dynamic Br;
        }
    }
}