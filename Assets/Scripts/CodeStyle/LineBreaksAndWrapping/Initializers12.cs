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
    // Arrangement of Initializers
    // ??????????????????
    public class Initializers12 : Base
    {
        // Keep existing arrangement of initializers
        // ???????????????????????????
        private void Foo1()
        {
            var result = new { A = 0 };
            var result1 = new { A = 0 };
        }

        // Place simple array, object and collection on single line 
        // ??????????????????????????????????????????????????????
        private void Foo2()
        {
            var result = new { A = 0 };
        }

        // Max object and collection initializer elements on a single line
        // ????????????MAX??????????????????????????????
        private void Foo3()
        {
            x = new C() { Prop1 = 1 };
            x = new C() { Prop1 = 1, Prop2 = 1 };
            x = new C() { Prop1 = 1, Prop2 = 1, Prop3 = 1 };
            x = new C() { Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1 };
            x = new C() { Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1, Prop5 = 1 };
            x = new C() { Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1, Prop5 = 1, Prop6 = 1 };
            x = new C() { Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1, Prop5 = 1, Prop6 = 1, Prop7 = 1 };
            x = new C() { Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1, Prop5 = 1, Prop6 = 1, Prop7 = 1, Prop8 = 1 };
            x = new C() { Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1, Prop5 = 1, Prop6 = 1, Prop7 = 1, Prop8 = 1, Prop9 = 1 };
        }

        // Wrap object and collection initializer
        // ????????????????????????????????????
        private void Foo4()
        {
            new C() { PropertyX = 1, PropertyY = 2, PropertyZ = 3 };
        }

        // Max array initializer elements on a single line
        // ???????????????????????????????????????

        private void Foo5()
        {
            x = new[] { val1 };
            x = new[] { val1, val2 };
            x = new[] { val1, val2, val3 };
            x = new[] { val1, val2, val3, val4 };
            x = new[] { val1, val2, val3, val4, val5 };
            x = new[] { val1, val2, val3, val4, val5, val6 };
            x = new[] { val1, val2, val3, val4, val5, val6, val7 };
            x = new[] { val1, val2, val3, val4, val5, val6, val7, val8 };
            x = new[] { val1, val2, val3, val4, val5, val6, val7, val8, val9 };
        }

        // Wrap array initializer
        // ????????????????????????
        private void Foo6()
        {
            var a = new C[] { Element1, ElementX, ElementY, ElementZ, ElementZzz };
        }
    }
}