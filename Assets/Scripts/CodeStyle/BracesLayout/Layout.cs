// Type and namespace declaration (类型和命名空间声明)
// Indent inside namespace declaration (在命名空间声明内缩进)

// Type and namespace declaration
// Indent inside namespace declaration

namespace N
{
    interface I
    {
        void foo();
    }

    class E
    {
    }
}

// 大括号布局
namespace CodeStyle.BracesLayout
{
    public class Layout : Base
    {

        // Method declaration (方法声明)
        // Method declaration
        class C
        {
            void Method()
            {
                foo();
                foo1();
            }
        }

        // Lambda and delegate (anonymous method declaration) （Lambda 和委托（匿名方法声明））
        // Lambda and delegate (anonymous method declaration)
        private void LambdaAndDelegate()
        {
            D d = delegate()
            {
                const int x = 0;
                return x;
            };
        }


        // Property declaration （属性声明）
        // Property declaration
        class E
        {
            int? Property { get { return null; } set { } }
        }


        // Accessor declaration（访问者声明）
        // Accessor declaration
        class H
        {
            int? Property
            {
                get { return null; }
                set
                {
                    Notify(value);
                    Set(value);
                }
            }
        }

        // Block under "case" label (在“case”标签下屏蔽)
        // Block under "case" label
        private void BlockUnder()
        {
            switch (expression)
            {
                case 0:
                {
                    foo();
                    break;
                }
            }
        }


        // Expressions (initializers, switch expressions, patterns) （表达式（初始化器、开关表达式、模式））
        // Use continuous line indent inside expression braces  （ 在表达式大括号内使用连续行缩进）
        // Expressions (initializers, switch expressions, patterns)
        // Use continuous line indent inside expression braces
        private void UseContinuous()
        {
            int[] array = new int[]
            {
                1,
                2,
                3
            };
        }


        // Other（其他）
        // Other
        private void Other()
        {
            if (condition)
            {
                foo();
            }
            else
            {
                foo();
            }

        }

        // Allow comment after '{' （允许在“{”后注释）
        // Allow comment after '{'
        private void AllowComment()
        {
            if (condition)
            {
                // comment
                statement++;
            }
        }


        // Empty braces formatting（空大括号格式）
        // Empty braces formatting
        class I
        {
            void EmptyMethod()
            {
            }
        }
    }
}