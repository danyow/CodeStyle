// 空行

namespace CodeStyle.BlankLines
{
    /// <summary>
    /// 通常
    /// </summary>
    public class General : Base
    {
        // Around region（region外面） -> 0
        // Inside region（region里面） -> 1

        abstract class C
        {
            protected abstract void Method1();

#region Region Description
            protected abstract void Method2();
#endregion

            protected abstract void Method3();
        }

        // Before single-line comment（单行注释前） -> 0
        private void Foo()
        {
            void Foo()
            {
                var x = 5;
                // comment
                Call();
                ////CommentedCall();
            }
        }
    }
}