// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable LocalVariableHidesMember
// ReSharper disable UnusedVariable
// ReSharper disable UnusedMember.Local
// ReSharper disable ConvertToUsingDeclaration
// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable UnusedType.Local
// ReSharper disable UnusedTypeParameter

namespace CodeStyle.TabIndentsAlignment
{
    public class OtherIndents5 : Base
    {
        /// <summary>
        /// 从Switch缩进Case
        /// </summary>
        // Indent" case ”from' switch
        private void IndentCaseFromSwitch()
        {
            switch (expression)
            {
                case 0:
                    break;
            }
        }

        /// <summary>
        /// 取消缩进声明标签
        /// </summary>
        // Outdent statement labels
        private void OutdentStatementLabels()
        {
            int a = 5;
            MyLabel:
            a--;
            if (a > 0) goto MyLabel;
        }

        /// <summary>
        /// Indent type constraints （缩进类型约束）
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        // Indent type constraints
        class C1<T1>
            where T1 : I1
        {
        }

        // Place comments at first column when commenting out code 
        // Use previous element's indent on partial format

        // Place comments at the first column when commenting out code. （注释掉代码时，将注释放在第一列。）
        // Place comments at the first column when commenting out code. Otherwise, comments will use the indentation level of the commented code.
        // （注释掉代码时，将注释放在第一列。否则，注释将使用被注释代码的缩进级别。）

        // Use previous element's indent on partial format.（在部分格式上使用前一个元素的缩进）
        // When formatting only a part of the file, try to take the indent from elements on previous lines (previous statements/class members/etc).
        // If turned off, the indent will be the parent element's (usually the parent block) indent plus the indent from the indent settings.
        // （当仅格式化文件的一部分时，尝试从前几行的元素中获取缩进（之前的语句类成员等）。
        // 如果关闭，缩进将是父元素（通常是父块）的缩进加上缩进设置中的缩进。）

        /// <summary>
        /// 在语句条件内缩进大括号
        /// </summary>
        // Indent braces inside statement conditions
        private void IndentBracesInsideStatementConditions()
        {

            while (x is IMyInterface
                   {
                       Prop1: 1,
                       Prop2: 2
                   })
            {
                DoSomething();
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