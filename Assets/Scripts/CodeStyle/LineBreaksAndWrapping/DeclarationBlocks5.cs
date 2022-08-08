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

#pragma warning disable CS0414
#pragma warning disable CS8509
#pragma warning disable CS0108, CS0114
#pragma warning disable CS8321
#pragma warning disable CS0219
#pragma warning disable CS0693
#pragma warning disable CS0472

using System;

namespace CodeStyle.LineBreaksAndWrapping
{
    public class DeclarationBlocks5 : Base
    {
        // Keep existing arrangement of declaration blocks
        interface I
        {
            int Property { get; set; }
        }

        interface I1
        {
            int Property { get; set; }
        }

        // Place abstract/auto property/indexer/event declaration on single line
        interface I2
        {
            int Property { get; set; }
        }

        // Place simple property/indexer/event declaration on single line
        class C
        {
            int Property { get { return x; } set { x = value; } }
            private dynamic x;
        }

        // Place it on single line even when it has attributes on accessors
        class C1
        {
            int Property
            {
                [Attr]
                get { return x; }
                [Attr]
                set { x = value; }
            }

            private dynamic x;
        }

        // Place simple accessor on single line 
        class C2
        {
            int Property
            {
                get { return x; }
                set
                {
                    if (value == null)
                    {
                        throw new Exception();
                    }
                }
            }

            private dynamic x;
        }

        // Place simple method on single line 
        class C3
        {
            void Foo()
            {
                DoSomethingSimple();
            }

            private dynamic DoSomethingSimple;
        }
    }
}