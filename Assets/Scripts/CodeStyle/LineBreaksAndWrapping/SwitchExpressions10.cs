namespace CodeStyle.LineBreaksAndWrapping
{
    // Arrangement of Switch Expressions
    // 开关表达式的排列
    public class SwitchExpressions10 : Base
    {
        // Keep existing arrangement of switch expressions
        // 保持现有的开关表达式的排列
        private void Foo1()
        {
            var result = x switch
            {
                T.A => 0, T.B => 1
            };
            var result1 = x switch { T.A => 0, T.B => 1 };
        }

        // Place simple switch expression on single line
        // 将简单的开关表达式放在单行上
        private void Foo2()
        {
            var result = x switch
            {
                T.A => 0, T.B => 1
            };
        }

        // Wrap switch expression
        // 包装开关表达式
        private void Foo3()
        {
            var a =
                (x switch
                {
                    T.A => 0,
                    T.B => 1,
                    T.C => 2
                }) +
                (x switch
                {
                    T.A => 0,
                    T.B => 1 +
                           2,
                    T.C => 2
                });
        }
    }
}