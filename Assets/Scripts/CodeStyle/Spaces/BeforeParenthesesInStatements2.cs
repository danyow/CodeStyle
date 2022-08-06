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

#pragma warning disable CS0414
#pragma warning disable CS8509
#pragma warning disable CS0108, CS0114
#pragma warning disable CS8321
#pragma warning disable CS0219
#pragma warning disable CS0693
#pragma warning disable CS0472
#pragma warning disable CS0168

using System;

namespace CodeStyle.Spaces
{
    // Before Parentheses in Statements
    public class BeforeParenthesesInStatements2 : Base
    {
        // "if" parentheses
        private void Foo1()
        {
            if (condition)
            {
                foo();
            }
            else
            {
                foo();
            }
        }

        // ”while" parentheses
        private void Foo2()
        {
            while (condition)
            {
                do
                {
                    foo();
                } while (condition);
            }
        }

        // "catch" parentheses
        private void Foo3()
        {
            try
            {
                foo();
            }
            catch (Exception e)
            {
            }
        }

        // ”switch" parentheses
        private void Foo4()
        {
            switch (expr)
            {
                case 0:
                    break;
            }
        }

        // "for" parentheses
        private void Foo5()
        {
            for (int i = 0; i < 10; i++)
            {
                foo();
            }
        }

        // "foreach" parentheses
        private void Foo6()
        {
            foreach (object o in collection)
            {
                foo();
            }
        }

        // "using" parentheses
        private void Foo7()
        {
            using (C c = new C())
            {
                foo();
            }
        }

        // "lock" parentheses
        private void Foo8()
        {
            lock (this)
            {
                foo();
            }
        }

        // "fixed" parentheses
        private unsafe void Foo9()
        {
            fixed (int* fib = new int[1])
            {
                foo();
            }
        }

    }
}