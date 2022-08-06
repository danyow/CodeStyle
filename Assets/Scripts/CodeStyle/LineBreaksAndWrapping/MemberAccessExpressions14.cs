namespace CodeStyle.LineBreaksAndWrapping
{
    // Arrangement of Member Access Expressions
    // 成员访问表达式的安排
    public class MemberAccessExpressions14 : Base
    {
        // Prefer wrap after "."
        // 更喜欢在“”之后加上“。”
        private void Foo1()
        {
            obj.Method()
                .Method()
                .Method()
                .Method()
                .Method()
                .Method()
                .Method()
                .Method()
                .Method()
                .Method();
        }

        // Wrap chained method calls
        // 包装链式方法调用
        private void Foo2()
        {
            var a = obj.Method().Method() +
                    obj.Method().Method()
                        .Method().Method()
                        .Method().Method()
                        .Method().Method()
                        .Method().Method();
        }
    }
}