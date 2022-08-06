using System;
using SomeClass = System.String;

namespace CodeStyle.Indents
{
    /// <summary>
    /// 在列中对齐相似的代码
    /// </summary>
    public class AlignSimilarCodeInColumns
    {
        // FixColumnAlignmentInAdjacentLines （修复相邻行中的列对齐）
        // When formatting some code, also fix column alignment in adjacent lines if needed
        // 格式化某些代码时，如果需要，还可以修复相邻行中的列对齐


        /// <summary>
        /// 字段和常量
        /// </summary>
        private class FieldsAndConstants
        {
            [Attr] private string x = "x";
            [Attr(2)] public SomeClass xxxxx = "xxxxx";
            [Attr, Attr3] private string xxx;
        }

        /// <summary>
        /// 属性和事件
        /// </summary>
        private class PropertiesAndEvents
        {
            [Attr] private string x { get; set; } = "x";
            [Attr(2)] public SomeClass xxxxx { get; set; } = default;
            [Attr, Attr3] private string xxx { get; }
            [Attr] private string x2 => "x";
            [Attr(2)] public SomeClass xxxxx2 => "xxxxx";
            [Attr, Attr3] private string xxx2 => "xxx";
        }

        /// <summary>
        /// 简单的方法、操作、代理
        /// </summary>
        private class SimpleMethodsOperatorsDelegates
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
        private void VariablesAndLocalConstants()
        {
            {
                var x = 1;
                var xxxxx = 2;
                var xxx = 2;
            }
        }

        /// <summary>
        /// 其他赋值和初始化器
        /// </summary>
        private void OtherAssignmentsAndInitializers()
        {
            var x = 1;
            var xxxxx = 2;
            var xxx = 2;

            {
                x = 1;
                xxxxx = 2;
                xxx = 2;
            }
        }

        /// <summary>
        /// 属性模式
        /// </summary>
        private void PropertyPatterns()
        {
            var sourceObject = Imitation.Value<object>();

            var matches = sourceObject is MyType
            {
                FShort: 1,
                FieldLongLong: 2,
            };
        }

        /// <summary>
        /// 嵌套三元运算符
        /// </summary>
        private void NestedTernaryOperators()
        {
            var y = Imitation.Value<string>();

            var x =
                y == "a" ? 1 :
                y == "aaaa" ? 4 :
                y == "aa" ? 2 :
                0;
        }


        /// <summary>
        /// 调用相同的方法
        /// </summary>
        private class InvocationsOfTheSameMethod
        {
            [Attr1("x", 1234567)]
            [Attr2("xxxxx", 1)]
            [Attr3(MyEnum.MyConstant, 124)]
            private void MyMethod()
            {
                CallMe("x", 1234567);
                CallMe("xxxxx", 1);
                CallMe(MyEnum.MyConstant, 124);
            }


            private static void CallMe(params object[] ps)
            {

            }
        }

        /// <summary>
        /// 二进制表达式
        /// </summary>
        private void BinaryExpressions()
        {

            var zzz = Imitation.Value<bool>();
            var someCondition = Imitation.Value<bool>();
            var otherCondition = Imitation.Value<bool>();
            var aa = Imitation.Value<bool>();
            var bb = Imitation.Value<bool>();
            var x = Imitation.Value<string>();
            var xxxxxxx = Imitation.Value<string>();
            var xx = Imitation.Value<MoreThen>();

            if (
                zzz ||
                someCondition && otherCondition ||
                aa && bb ||
                x == "a" ||
                xxxxxxx != "aaaa" ||
                xx > "aa")
            {
                Imitation.DoSomething();
            }
        }


        /// <summary>
        /// 结尾注释
        /// </summary>
        private void EndComments()
        {
            Imitation.DoSomething();     // I'm
            var y = 6;                   // forced
            while (y > 0) y--;           // to
            Imitation.DoSomethingElse(); /* document */
            var z = 10;                  /* my code */
            while (z < 100) z++;         /* profusely */
        }

        /// <summary>
        /// 简单的Switch
        /// </summary>
        /// <returns></returns>
        private int SimpleSwitchSections()
        {
            var op = Imitation.Value<Op>();
            var x = Imitation.Value<int>();
            var y = Imitation.Value<int>();

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
        private void SwitchExpressions()
        {
            var op = Op.Add;
            var x = Imitation.Value<int>();
            var y = Imitation.Value<int>();

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