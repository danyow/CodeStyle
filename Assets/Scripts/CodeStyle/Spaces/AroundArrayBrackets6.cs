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

namespace CodeStyle.Spaces
{
    // Around Array Brackets
    public class AroundArrayBrackets6 : Base
    {
        // Before array access brackets
        private void Foo1()
        {
            array[i] = array[i + 1];
        }

        // Before array rank brackets
        private void Foo2()
        {
            int[][,] x = null;
        }

        // Within array access brackets
        private void Foo3()
        {
            array[i] = array[i + 1];
        }

        // Within array rank brackets
        private void Foo4()
        {
            int[,] x = new int[1, 2];
        }

        // Within array rank empty brackets
        private void Foo5()
        {
            int[][,] x = null;
        }

    }
}