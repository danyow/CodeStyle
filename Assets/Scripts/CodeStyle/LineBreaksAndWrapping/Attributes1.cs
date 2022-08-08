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

#pragma warning disable CS0414
#pragma warning disable CS8509
#pragma warning disable CS0108, CS0114
#pragma warning disable CS8321
#pragma warning disable CS0219

namespace CodeStyle.LineBreaksAndWrapping
{
    public class Attributes1 : Base
    {
        // Place attribute section list on separate line if it is longer than
        // Attribute sections longer than specified values would be placed on separate line

        // Keep exiting arrangement of attributes
        [Attribute]
        class C
        {
        }

        [Attribute]
        class C1
        {
        }

        // Place type attribute on the same line
        [Attribute]
        class C2
        {
        }

        [Attribute]
        class C3
        {
            // comment 
        }

        // Place method attribute on the same line
        interface I
        {
            [Attribute]
            void foo();
        }

        class C4
        {
            [Attribute]
            void foo()
            {
                // comment
            }
        }

        // Place property/indexer/event attribute on the same line

        interface I2
        {
            [Attribute]
            int Property { get; }
        }

        class C5
        {
            [Attribute]
            int Property
            {
                get
                {
                    // comment
                    return x;
                }
            }
        }

        // Place accessor attribute on the same line
        interface I3
        {
            int Property
            {
                [Attribute]
                get;
            }
        }

        class C6
        {
            int Property
            {
                [Attribute]
                get { return x; }
                [Attribute]
                set
                {
                    x = value;
                    NotifySomething();
                }
            }
        }

        // Place field attribute on the same line
        class C7
        {
            [Attribute]
            int x;

            [Attribute]
            MyObj y = // comment 
                new MyObj();
        }
    }
}