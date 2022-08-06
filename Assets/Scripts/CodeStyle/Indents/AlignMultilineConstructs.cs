using System;
using System.Linq;

namespace CodeStyle.Indents
{
    /// <summary>
    /// 对齐多行结构
    /// </summary>
    public class AlignMultilineConstructs
    {

        /// <summary>
        /// 制表符用于缩进时如何对齐
        /// </summary>
        private void HowToAlignWhenTabsAreUsedForIndents()
        {
            var param1 = Imitation.Value<object>();
            var param2 = Imitation.Value<object>();

            Imitation.SomeMyMethod(
                param1,
                param2
            );
        }


        // Align even if the resulting indentation is too large.（即使结果缩进太大也对齐）
        // Allow alignment even if construct is located too far to the right, more than 2/3 of `Hard wrap at` limit
        // 即使构造位置太靠右，也允许对齐，超过 23 的 `Hard wrap at` 限制

        /// <summary>
        /// 方法参数
        /// </summary>
        private void MethodParameters(
            int firstParameter,
            int secondParameter
        )
        {

        }

        /// <summary>
        /// List of base classes and interfaces.（基类和接口列表）
        /// </summary>
        private class C : BaseClass,
            ISomeInterface
        {
        }

        /// <summary>
        /// Linq 查询
        /// </summary>
        private void LinqQuery()
        {

            var xs = Imitation.Value<object[]>();
            var q = from x in xs
                where x != null
                select x;
        }

        /// <summary>
        /// 二进制表达式
        /// </summary>
        private void BinaryExpressions()
        {
            var someOperand = Imitation.Value<int>();
            var operand2 = Imitation.Value<int>();
            var operand3 = Imitation.Value<int>();
            var operand4 = Imitation.Value<int>();

            var a = someOperand + operand2
                                + operand3
                                + operand4;
        }

        /// <summary>
        /// 反缩进二进制表达式
        /// </summary>
        private void OutdentBinaryOperators()
        {
            var someOperand = Imitation.Value<int>();
            var operand2 = Imitation.Value<int>();
            var operand3 = Imitation.Value<int>();
            var operand4 = Imitation.Value<int>();

            var a =
                someOperand
                + operand2
                + operand3
                + operand4;
            var b = someOperand
                    + operand2
                    + operand3
                    + operand4;
        }

        /// <summary>
        /// 链式方法调用
        /// </summary>
        private void ChainedMethodCalls()
        {
            Imitation.SomeMethod()
                .OtherMethod()
                .ThirdMethod();
        }

        /// <summary>
        /// 链式方法调用中的点
        /// </summary>
        private void OutdentDotsInChainedMethodCalls()
        {
            var a =
                ImitationStruct
                    .SomeMethod()
                    ?.OtherMethod()
                    .ThirdMethod();
            var b = ImitationStruct
                .SomeMethod()
                ?.OtherMethod()
                .ThirdMethod();
        }

        /// <summary>
        /// 数组对象和集合初始化器
        /// </summary>
        private void ArrayObjectAndCollectionInitializer()
        {
            var student = new StudentName
            {
                FirstName = "John",
                LastName = "Smith",
                ID = 116,
            };
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
                Op.Add => x + y,
                Op.Subtract => x - y,
                Op.Multiply => x * y,
                Op.Divide => x / y
            };
        }


        /// <summary>
        /// 属性模式
        /// </summary>
        private void PropertyPatterns()
        {
            var sourceObject = Imitation.Value<object>();

            var matches = sourceObject is MyType
            {
                Field1: 1,
                Field2: 2,
            };
        }


        /// <summary>
        /// 二进制模式
        /// </summary>
        private void BinaryPatterns()
        {
            var e = Imitation.Value<int>();
            const int someOperand = 1;
            const int operand2 = 2;
            const int operand3 = 3;
            const int operand4 = 4;

            var a = e is someOperand or operand2
                or operand3
                or operand4;
        }


        /// <summary>
        /// 反缩进 二进制模式
        /// </summary>
        private void OutdentBinaryPatterns()
        {
            var e = Imitation.Value<int>();
            const int someOperand = 1;
            const int operand2 = 2;
            const int operand3 = 3;
            const int operand4 = 4;

            var a = e is
                someOperand
                or operand2
                or operand3
                or operand4;
            var b = e is someOperand
                or operand2
                or operand3
                or operand4;
        }


        /// <summary>
        /// 匿名方法体
        /// </summary>
        private void AnonymousMethodBody()
        {
            Imitation.FooCall(
                delegate
                {
                    Imitation.DoSomething();
                    return 0;
                }
            );
        }

        /// <summary>
        /// 左调用参数
        /// </summary>
        private void CallArgumentsByLeft()
        {
            var firstParameter = Imitation.Value<object>();
            var secondParameter = Imitation.Value<object>();

            Imitation.Method(
                firstParameter,
                secondParameter
            );
        }

        /// <summary>
        /// 左调用参数
        /// </summary>
        private void CallArguments()
        {
            var firstParameter = Imitation.Value<object>();
            var secondParameter = Imitation.Value<object>();

            Imitation.Method(
                firstParameter,
                secondParameter
            );
        }


        /// <summary>
        /// 元组组件
        /// </summary>
        private void TupleComponents()
        {
            var firstParameter = Imitation.Value<object>();
            var secondParameter = Imitation.Value<object>();

            var tuple = (firstParameter,
                secondParameter);
        }


        /// <summary>
        /// 其他表达
        /// </summary>
        private void OtherExpressions()
        {
            var destination = Imitation.Value<bool>();
            var source1 = Imitation.Value<bool>();
            var source2 = Imitation.Value<bool>();
            var source3 = Imitation.Value<bool>();

            destination = source1
                ? source2
                : source3;
        }


        /// <summary>
        /// 括号内的语句条件
        /// </summary>
        private void StatementConditionsInsideParenthesis()
        {
            var x = Imitation.Value<object>();

            while (x is IMyInterface or
                   IMyInterface2 or
                   IMyInterface3
                   {
                       Prop1: 1,
                       Prop2: 2,
                   })
            {
                Imitation.DoSomething();
            }
        }

        /// <summary>
        /// for 语句头
        /// </summary>
        private void ForStatementHeader()
        {
            for (var i = 0;
                 i < 10;
                 i++)
            {
            }
        }

        /// <summary>
        /// 多重声明
        /// </summary>
        /// <summary>
        /// MultipleDeclarations
        /// </summary>
        private class MultipleDeclarations
        {
            private int i = 0,
                j = 10;
        }

        /// <summary>
        /// 类型参数列表
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        private class TypeParametersList<T1,
            T2,
            T3>
        {
        }

        /// <summary>
        /// 类型参数约束
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        private class TypeParametersConstraints<T1, T2> where T1 : I1
            where T2 : I1
        {
        }

        /// <summary>
        /// 突出的逗号
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T3"></typeparam>
        private class OutdentCommas<
            T1
            , T3> :
            BaseClass
            , ISomeInterface
        {
            private void FooCall(
                int firstParameter,
                int secondParameter
            )
            {
                FooCall(
                    firstParameter,
                    secondParameter
                );
            }
        }
    }
}