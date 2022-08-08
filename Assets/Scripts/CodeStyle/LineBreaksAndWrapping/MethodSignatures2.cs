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

namespace CodeStyle.LineBreaksAndWrapping
{
    public class MethodSignatures2
    {
        // Wrap formal parameters
        interface IA
        {
            void M(int p1, int p2);

            void SomeMethod(
                int p1,
                int p2,
                int p3,
                int p4
            );
        }

        // Max formal parameters on a single line
        interface IA1
        {
            void M(int arg1);
            void M(int arg1, int arg2);
            void M(int arg1, int arg2, int arg3);
            void M(int arg1, int arg2, int arg3, int arg4);
            void M(int arg1, int arg2, int arg3, int arg4, int arg5);
            void M(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6);
            void M(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7);
            void M(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8);
            void M(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9);
        }

        // Keep existing arrangement of parenthesis in declaration
        void SomeMethod0(int p1, int p2, int p3, int p4)
        {
        }

        // Prefer wrap before "(" in declaration
        // Prefer wrap after ")" in declaration
        // Prefer wrap before "(" in declaration
        void SomeMethod(
            int p1,
            int p2,
            int p3,
            int p4
        )
        {
        }

        // Allow constructor initializer on the same line
        class C
        {
            public C() : base()
            {
            }
        }
    }
}