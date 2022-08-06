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

#pragma warning disable CS0414
#pragma warning disable CS8509
#pragma warning disable CS0108, CS0114
#pragma warning disable CS8321
#pragma warning disable CS0219
#pragma warning disable CS0693
#pragma warning disable CS0472
#pragma warning disable CS0168

using System;
using System.Collections.Generic;

namespace CodeStyle.Spaces
{
    // Within Other Parentheses
    public class WithinOtherParentheses5 : Base
    {
        // Parentheses
        private void Foo1()
        {
            a = b * (c + d);
        }

        // Type cast parentheses
        private void Foo2()
        {
            int a = (int)b;
        }

        // Method declaration parentheses
        abstract class C
        {
            public abstract void Method1(string str);
            public abstract void Method2();
        }

        // Method declaration empty parentheses
        abstract class C1
        {
            public abstract void Method1(string str);
            public abstract void Method2();
        }

        // Method call parentheses
        void Method()
        {
            foo1("string", true);
            foo2();
        }

        // Method call empty parentheses
        void Method1()
        {
            foo1("string", true);
            foo2();
        }

        // "typeof" parentheses
        private void Foo7()
        {
            Type t = typeof(bool);
        }

        // "default" parentheses
        private dynamic Foo8()
        {
            return default(int);
        }

        // "checked" and "unchecked" parentheses
        private dynamic Foo9()
        {
            return checked(100000 * 10000) + unchecked(10000 * 10000);
        }

        // "sizeof" parentheses
        private void Foo10()
        {
            int size = sizeof(bool);
        }

        // ”nameof" parentheses
        private dynamic Foo11()
        {
            return nameof(myField);
        }

        // ”new" parentheses
        private void Foo12()
        {
            List<int> x = new(5);
        }

    }
}