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
    // Arrangement of Ternary Expressions
    // 三元表达式的排列
    public class TernaryExpressions16 : Base
    {

        // Prefer wrap before "?" and "." in ternary expressions
        // 更喜欢“？”之前的包装。还有“。”在三元表达式中
        private dynamic Foo1()
        {
            return hereGoesSomeBoolExpression
                ? returnThisIfTrue
                : returnThatIfFalse;
        }

        // Wrap ternary expression
        // 包装三元表达式
        private void Foo2()
        {
            myField = someCondition
                ? true
                : false;
        }

        // Nested ternary expression style
        // 嵌套三值表达式样式
        private void Foo3()
        {
            a = i ? "am" :
                you ? "are" : "is";

            b = error ? red :
                warning ? yellow :
                green;

            c = tiger ? dangerous :
                cat ? cute : boring;

            d = roses ? red :
                violets ? blue : so_are_you;
        }
    }
}