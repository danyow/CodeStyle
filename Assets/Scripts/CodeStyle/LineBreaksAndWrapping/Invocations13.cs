namespace CodeStyle.LineBreaksAndWrapping
{
    // Arrangement of Invocations
    // 调用安排
    public class Invocations13 : Base
    {
        // Wrap invocation arguments
        // 包装调用参数
        private void Foo1()
        {
            CallMethod(arg1, arg2);
            CallMethod(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5
            );
        }

        // Max invocation arguments on a single line
        // 单行上的最大调用参数
        private void Foo2()
        {
            CallMethod(arg1);
            CallMethod(arg1, arg2);
            CallMethod(arg1, arg2, arg3);
            CallMethod(arg1, arg2, arg3, arg4);
            CallMethod(arg1, arg2, arg3, arg4, arg5);
            CallMethod(arg1, arg2, arg3, arg4, arg5, arg6);
            CallMethod(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            CallMethod(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            CallMethod(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        // Keep existing arrangement of parenthesis in invocation
        // 将括号的现有安排保留在调用中
        private void Foo3()
        {
            CallMethod(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5
            );
        }

        // Prefer wrap before "(" in invocation
        // 在调用中，更喜欢在“(”)之前换行
        // Prefer wrap after "(" in invocation
        // 更喜欢在调用中的“(”)后面换行
        // Prefer wrap before ")" in invocation
        // 在调用中更喜欢在“)”之前换行
        private void Foo4()
        {
            CallMethod(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5
            );
        }
    }
}