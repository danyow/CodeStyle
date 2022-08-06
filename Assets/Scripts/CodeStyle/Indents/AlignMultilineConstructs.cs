using System;
using System.Linq;

namespace CodeStyle.Indents
{
    /// <summary>
    /// 对齐多行结构
    /// </summary>
    public class AlignMultilineConstructs : Base
    {

        /// <summary>
        /// 制表符用于缩进时如何对齐
        /// </summary>
        // How to align when tabs are used for indents
        private void HowToAlignWhenTabsAreUsedForIndents()
        {
            SomeMyMethod(param1,
                param2);
        }


        // Align even if the resulting indentation is too large
        // Align even if the resulting indentation is too large.（即使结果缩进太大也对齐）
        // Allow alignment even if construct is located too far to the right, more than 2/3 of `Hard wrap at` limit
        // 即使构造位置太靠右，也允许对齐，超过 23 的 `Hard wrap at` 限制

        /// <summary>
        /// 方法参数
        /// </summary>
        // Method parameters
        private void MethodParameters()
        {
            void fooCall(int firstParameter,
                int secondParameter)
            {
            }
        }

        /// <summary>
        /// List of base classes and interfaces.（基类和接口列表）
        /// </summary>
        // List of base classes and interfaces
        class C : BaseClass,
            ISomeInterface
        {
        }

        /// <summary>
        /// Linq 查询
        /// </summary>
        // LINQ query 
        private void LinqQuery()
        {

            var q = from x in xs
                where x != null
                select x;
        }

        /// <summary>
        /// 二进制表达式
        /// </summary>
        // Binary expressions
        private void BinaryExpressions()
        {
            var a = someOperand + operand2
                                + operand3
                                + operand4;
        }

        /// <summary>
        /// 反缩进二进制表达式
        /// </summary>
        // Outdent binary operators
        private void OutdentBinaryOperators()
        {
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
        // Chained method calls
        private void ChainedMethodCalls()
        {
            MyVar.SomeMethod()
                .OtherMethod()
                .ThirdMethod();
        }

        /// <summary>
        /// 链式方法调用中的点
        /// </summary>
        // Outdent dots in chained method calls
        private void OutdentDotsInChainedMethodCalls()
        {
            var a =
                MyVar
                    .SomeMethod()
                    ?.OtherMethod()
                    .ThirdMethod();
            var b = MyVar
                .SomeMethod()
                ?.OtherMethod()
                .ThirdMethod();
        }

        /// <summary>
        /// 数组对象和集合初始化器
        /// </summary>
        // Array, object and collection initializer
        private void ArrayObjectAndCollectionInitializer()
        {
            StudentName student = new StudentName
            {
                FirstName = "John",
                LastName = "Smith",
                ID = 116
            };
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


        /// <summary>
        /// 属性模式
        /// </summary>
        // Property patterns
        private void PropertyPatterns()
        {
            bool matches = sourceObject is MyType {
                Field1: 1,
                Field2: 2,
            };
        }


        /// <summary>
        /// 二进制模式
        /// </summary>
        // Binary patterns 
        private void BinaryPatterns()
        {
            // const int someOperand = 1;
            // const int operand2 = 2;
            // const int operand3 = 3;
            // const int operand4 = 4;

            var a = e is someOperand or operand2
                or operand3
                or operand4;
        }


        /// <summary>
        /// 反缩进 二进制模式
        /// </summary>
        // Outdent binary patterns
        private void OutdentBinaryPatterns()
        {
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
        // Anonymous method body
        private void AnonymousMethodBody()
        {
            FooCall(delegate
            {
                DoSomething();
                return 0;
            });
        }

        /// <summary>
        /// 左调用参数
        /// </summary>
        // Call arguments by '(
        private void CallArgumentsByLeft()
        {
            fooCall(
                firstParameter,
                secondParameter);
        }

        /// <summary>
        /// 左调用参数
        /// </summary>
        // Call arguments
        private void CallArguments()
        {
            fooCall(firstParameter,
                secondParameter);
        }


        /// <summary>
        /// 元组组件
        /// </summary>
        // Tuple components 
        private void TupleComponents()
        {
            var tuple = (firstParameter,
                secondParameter);
        }


        /// <summary>
        /// 其他表达
        /// </summary>
        // Other expressions
        private void OtherExpressions()
        {
            destination = source1
                ? source2
                : source3;
        }


        /// <summary>
        /// 括号内的语句条件
        /// </summary>
        // Statement conditions inside parenthesis
        private void StatementConditionsInsideParenthesis()
        {
            while (x is IMyInterface or
                   IMyInterface2 or
                   IMyInterface3
                   {
                       Prop1: 1,
                       Prop2: 2
                   })
            {
                DoSomething();
            }
        }

        /// <summary>
        /// for 语句头
        /// </summary>
        // ”for" statement header
        private void ForStatementHeader()
        {
            for (int i = 0;
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
        // Multiple declarations
        class D
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
        // Type parameters list
        class Class<T1,
            T2,
            T3>
        {
        }

        /// <summary>
        /// 类型参数约束
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        // Type parameter constraints
        class C<T1, T2> where T1 : I1
            where T2 : I1
        {
        }
        
        /// <summary>
        /// 突出的逗号
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T3"></typeparam>
        // Outdent commas
        class Class<
            T1
            , T3> :
            Base
            , ISomeInterface
        {
            void fooCall(
                int firstParameter
                , int secondParameter)
            {
                fooCall(
                    firstParameter
                    , secondParameter);
            }
        }
    }
}