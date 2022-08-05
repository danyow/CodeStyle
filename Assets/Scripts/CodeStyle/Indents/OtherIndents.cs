namespace CodeStyle.Indents
{
    public class OtherIndents
    {
        /// <summary>
        /// 从Switch缩进Case
        /// </summary>
        private void IndentCaseFromSwitch()
        {
            var expression = Fake.Foo1();

            switch (expression)
            {
                case 0:
                    break;
            }
        }

        /// <summary>
        /// 取消缩进声明标签
        /// </summary>
        private void OutdentStatementLabels()
        {
            var a = 5;
            MyLabel:
            a--;
            if (a > 0) goto MyLabel;
        }

        /// <summary>
        /// Indent type constraints （缩进类型约束）
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        class C1<T1>
            where T1 : I1
        {
        }

        /// <summary>
        /// 在语句条件内缩进大括号
        /// </summary>
        private void IndentBracesInsideStatementConditions()
        {

            var x = Fake.Object();
            while (x is IMyInterface
                   {
                       Prop1: 1,
                       Prop2: 2
                   })
            {
                Fake.DoSomething();
            }
        }

    }
}

// Don't indent comments started at first column （不要缩进从第一列开始的注释）
namespace N
{
// Some comment
    class D
    {
    }
}

// Place comments at the first column when commenting out code. （注释掉代码时，将注释放在第一列。）
// Place comments at the first column when commenting out code. Otherwise, comments will use the indentation level of the commented code.
// （注释掉代码时，将注释放在第一列。否则，注释将使用被注释代码的缩进级别。）

// Use previous element's indent on partial format.（在部分格式上使用前一个元素的缩进）
// When formatting only a part of the file, try to take the indent from elements on previous lines (previous statements/class members/etc).
// If turned off, the indent will be the parent element's (usually the parent block) indent plus the indent from the indent settings.
// （当仅格式化文件的一部分时，尝试从前几行的元素中获取缩进（之前的语句类成员等）。
// 如果关闭，缩进将是父元素（通常是父块）的缩进加上缩进设置中的缩进。）