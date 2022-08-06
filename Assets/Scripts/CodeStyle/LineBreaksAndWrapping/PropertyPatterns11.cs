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
    // Arrangement of Property Patterns
    // 财产模式的安排
    public class PropertyPatterns11 : Base
    {
        // Keep existing arrangement of property patterns
        // 保持现有的财产模式安排
        private void Foo1()
        {
            bool matches = sourceObject is MyType
                           {
                               F1: 1,
                               F2: 2
                           } &&
                           sourceObject is MyType { F1: 1, F2: 2 };
        }

        // Place simple property pattern on single line
        // 在单行上放置简单的属性模式
        private void Foo2()
        {
            bool matches = sourceObject is MyType { F1: 1, F2: 2 };
        }

        // Wrap property pattern
        // 包装特性模式
        private void Foo3()
        {
            bool matches =
                sourceObject is MyType
                {
                    F1: 1, F2: 2
                } &&
                sourceObject is MyType
                {
                    F1: 1,
                    F2: 2,
                    F3: 3,
                    F4: 4,
                    F5: 5,
                    F6: 6,
                    F7: 7,
                    F8: 8
                };
        }
    }
}