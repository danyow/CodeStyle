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
    // Arrangement of Binary Expressions
    // ????????????????????????
    public class BinaryExpressions15 : Base
    {
        // Prefer wrap before operator in binary expression
        // ?????????????????????????????????????????????????????????
        private void Foo1()
        {
            myField1 = expression1 +
                       expression2 +
                       expression3 +
                       expression4 +
                       expression5 +
                       expression6 +
                       expression7;
        }

        // Wrap chained binary expressions
        // ??????????????????????????????
        private void Foo2()
        {
            b = a != b &&
                c != d &&
                e &&
                f.IsSumOf(g, h) &&
                i.Value == j &&
                k == l &&
                m == n &&
                o == p;
        }

        // Prefer wrap before operator in binary pattern
        // ????????????????????????????????????????????????????????????
        private void Foo3()
        {
            b = foo is VeryLongName1
                or VeryLongName2
                or VeryLongName3
                or VeryLongName4
                or VeryLongName5;
        }

        // Wrap complex binary patterns
        // ???????????????????????????
        private void Foo4()
        {
            b = foo is C1 or C2 or C3 or C4
                or C5 or VeryLongName1
                or VeryLongName2
                or VeryLongName3;
        }

        // Force chop compound condition in "if" statement
        // ???if???????????????????????????????????????
        private void Foo5()
        {
            if (var1 == null || var2 == null)
            {
                Foo();
            }
        }

        // Force chop compound condition in "while" statement
        // ????????????????????????????????????????????????
        private void Foo6()
        {
            while (var1 == null || var2 == null)
            {
                Foo();
            }
        }

        // Force chop compound condition in "do" statement
        // ???do???????????????????????????????????????
        private void Foo7()
        {
            do
            {
                Foo();
            } while (var1 == null || var2 == null);
        }
    }
}