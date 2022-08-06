// Type and namespace declaration (类型和命名空间声明)
// Indent inside namespace declaration (在命名空间声明内缩进)
namespace N
{
    interface I
    {
        void Foo();
    }

    class E
    {
    }
}
// 大括号布局
namespace CodeStyle.BracesLayout
{
    public class Layout
    {
        
        // Method declaration (方法声明)
        static class D
        {
            private static void Method()
            {
                Imitation.Foo1();
                Imitation.Foo2();
            }
        }

        // Lambda and delegate (anonymous method declaration) （Lambda 和委托（匿名方法声明））
        private delegate int Del();
        private void LambdaAndDelegate()
        {
            Del d = delegate()
            {
                const int x = 0;
                return x;
            };
        }
        

        // Property declaration （属性声明）
        private class E
        {
            private int? Property { get { return null; } set { } }
        }


        // Accessor declaration（访问者声明）
        private class F
        {
            private int? Property
            {
                get { return null; }
                set
                {
                    Notify(value);
                    Set(value);
                }
            }

            private static void Notify(int? v)
            {
                
            }
            
            private static void Set(int? v)
            {
                
            }
        }

        // Block under "case" label (在“case”标签下屏蔽)
        private void BlockUnder()
        {
            var expression = Imitation.Value<int>();
            switch (expression)
            {
                case 0:
                {
                    Imitation.Foo1();
                    break;
                }
            }
        }


        // Expressions (initializers, switch expressions, patterns) （表达式（初始化器、开关表达式、模式））
        // Use continuous line indent inside expression braces  （ 在表达式大括号内使用连续行缩进）
        private void UseContinuous()
        {
            var array = new []
            {
                1,
                2,
                3,
            };
        }



        // Other（其他）
        private void Other()
        {
            var condition = Imitation.Value<bool>();
            if (condition)
            {
                Imitation.Foo1();
            }
            else
            {
                Imitation.Foo1();
            }

        }
        
        // Allow comment after '{' （允许在“{”后注释）
        private void AllowComment()
        {
            var condition = Imitation.Value<bool>();
            var statement = Imitation.Value<int>();
            
            if (condition)
            {
                // comment
                statement++;
            }
        }


        // Empty braces formatting（空大括号格式）
        private class C
        {
            private void EmptyMethod()
            {
            }
        }
    }
}




