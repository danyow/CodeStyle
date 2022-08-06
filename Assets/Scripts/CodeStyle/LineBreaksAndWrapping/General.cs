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

#pragma warning disable CS0414
#pragma warning disable CS8509
#pragma warning disable CS0108, CS0114
#pragma warning disable CS8321
#pragma warning disable CS0219

namespace CodeStyle.LineBreaksAndWrapping
{
    public class General : Base
    {
        // Keep existing line breaks

        private void KeepExistingLineBreaks()
        {
            int var = condition
                ? SomeFunc1()
                : SomeFunc2();
        }

        // Wrap long lines
        // Wrap long lines
        // When enabled:  
        // string output = string.Format(CultureInfo.InvariantCulture,
        //                               "{0:yyyy-MM-dd} {1}", date, message);
        // When disabled:
        // string output = string.Format(CultureInfo.InvariantCulture, "{0:yyyy-MM-dd} {1}", date, message);

        // Hard wrap at
        // Hard wrap at
        // This option (similarly to the Editorconfig's 'max_line_length') defines the desired maximum number of characters in each line.
        // It is applied during code reformatting if 'Wrap long lines' is enabled.
        // Line breaks are added, if possible, at the positions not exceeding the specified value,
        // according to the language syntax and other line wrapping settings.

        // Prefer wrap before
        private void PreferWrapBefore()
        {
            CallMethod(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7
            );
        }

        // Prefer wrap before"
        private void PreferWrapBefore2()
        {
            myObject.ImportantField +=
                someRatherLongExpression;
        }


        // Special”else if" treatment
        private void SpecialElseIfTreatment()
        {
            if (condition)
            {
                foo();
            }
            else if (condition)
            {
            }
        }

        // Line feed at end of file
        class A
        {
        }
    }
}