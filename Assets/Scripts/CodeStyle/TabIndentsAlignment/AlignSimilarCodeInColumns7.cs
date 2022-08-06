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
// ReSharper disable ConvertConditionalTernaryExpressionToSwitchExpression

#pragma warning disable CS0414
#pragma warning disable CS8509
#pragma warning disable CS0108, CS0114
#pragma warning disable CS8321
#pragma warning disable CS0219

using SomeClass = System.String;

namespace CodeStyle.TabIndentsAlignment
{
    /// <summary>
    /// 在列中对齐相似的代码
    /// </summary>
    public class AlignSimilarCodeInColumns7 : Base
    {
        // Fix column alignment in adjacent lines
        // FixColumnAlignmentInAdjacentLines （修复相邻行中的列对齐）
        // When formatting some code, also fix column alignment in adjacent lines if needed
        // 格式化某些代码时，如果需要，还可以修复相邻行中的列对齐


        /// <summary>
        /// 字段和常量
        /// </summary>
        // Fields and constants
        class C
        {
            [Attr] private string x = "x";
            [Attr(2)] public SomeClass xxxxx = "xxxxx";
            [Attr, Attr3] private string xxx;
        }

        /// <summary>
        /// 属性和事件
        /// </summary>
        // Properties and events
        class D
        {
            [Attr] private string x { get; set; } = "x";
            [Attr(2)] public SomeClass xxxxx { get; set; } = SomeClass.Empty;
            [Attr, Attr3] private string xxx { get; }
            [Attr] private string x2 => "x";
            [Attr(2)] public SomeClass xxxxx2 => "xxxxx";
            [Attr, Attr3] private string xxx2 => "xxx";
        }

        /// <summary>
        /// 简单的方法、操作、代理
        /// </summary>
        // Simple methods, operators, delegates
        class E
        {
            [Attr] private string x(int p)
            {
                return "x" + p;
            }

            [Attr(2)] public SomeClass xxxxx(string b)
            {
                return b;
            }

            [Attr, Attr3] private string xxx()
            {
                return null;
            }

            [Attr] private string x2(int p) => "x" + p;
            [Attr(2)] public SomeClass xxxxx2(string b) => b;
            [Attr, Attr3] private string xxxx() => null;
        }

        /// <summary>
        /// 多行方法签名
        /// </summary>
        // Multiline method signature
        private interface IMultilineMethodSignature
        {
            void MyMethod(
                [Attr, Attr3] string xxx,
                [Attr] string x = "x",
                [Attr(2)] SomeClass xxxxx = "xxxxx"
            )
            {
            }
        }

        /// <summary>
        /// 变量和局部常量
        /// </summary>
        // Variables and local constants
        private void VariablesAndLocalConstants()
        {
            var x = 1;
            var xxxxx = 2;
            var xxx = 2;
        }

        /// <summary>
        /// 其他赋值和初始化器
        /// </summary>
        // Other assignments and initializers
        private void OtherAssignmentsAndInitializers()
        {
            x = 1;
            xxxxx = 2;
            xxx = 2;
        }

        /// <summary>
        /// 属性模式
        /// </summary>
        // Property patterns
        private void PropertyPatterns()
        {
            bool matches = sourceObject is MyType
            {
                FShort: 1,
                FieldLongLong: 2,
            };
        }

        /// <summary>
        /// 嵌套三元运算符
        /// </summary>
        // Nested ternary operators
        private void NestedTernaryOperators()
        {
            var x =
                y == "a" ? 1 :
                y == "aaaa" ? 4 :
                y == "aa" ? 2 :
                0;
        }


        /// <summary>
        /// 调用相同的方法
        /// </summary>
        // Invocations of the same method
        private class InvocationsOfTheSameMethod
        {
            [Attr1("x", 1234567)]
            [Attr2("xxxxx", 1)]
            [Attr3(MyEnum.MyConstant, 124)]
            void MyMethod()
            {
                CallMe("x", 1234567);
                CallMe("xxxxx", 1);
                CallMe(MyEnum.MyConstant, 124);
            }
        }

        /// <summary>
        /// 二进制表达式
        /// </summary>
        // Binary expressions
        private void BinaryExpressions()
        {

            if (
                zzz ||
                someCondition && otherCondition ||
                aa && bb ||
                x == "a" ||
                xxxxxxx != "aaaa" ||
                xx > "aa")
            {
                DoSomething();
            }
        }


        /// <summary>
        /// 结尾注释
        /// </summary>
        // End comments
        private void EndComments()
        {
            DoSomething();       // I'm
            var y = 6;           // forced
            while (y > 0) y--;   // to
            DoSomethingElse();   /* document */
            var z = 10;          /* my code */
            while (z < 100) z++; /* profusely */
        }

        /// <summary>
        /// 简单的Switch
        /// </summary>
        /// <returns></returns>
        // Simple switch sections 
        private int SimpleSwitchSections()
        {
            switch (op)
            {
                case Op.Add:      return x + y;
                case Op.Subtract: return x - y;
                case Op.Multiply: return x * y;
                case Op.Divide:   return x / y;
            }

            return 0;
        }


        /// <summary>
        /// Switch 表达式 
        /// </summary>
        // Switch expressions
        private void SwitchExpressions()
        {
            var z = op switch
            {
                Op.Add      => x + y,
                Op.Subtract => x - y,
                Op.Multiply => x * y,
                Op.Divide   => x / y
            };
        }
    }
}