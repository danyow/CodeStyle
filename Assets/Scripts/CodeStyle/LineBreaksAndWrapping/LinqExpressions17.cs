using System.Linq;

namespace CodeStyle.LineBreaksAndWrapping
{
    // Arrangement of LINQ Expressions
    // LINQ表达式的排列
    public class LinqExpressions17: Base
    {
        // Wrap LINQ expressions 
        // 包装LINQ表达式
        private void Foo1()
        {
            var result = from x in list
                where cond(x)
                select x;
        }
        // Prefer wrap before multiline LINQ expressions
        // 更喜欢在多行LINQ表达式之前换行
        private void Foo2()
        {
            var result = from x in list
                where cond(x)
                select x;
        }
        // Place "into" on new line in LINQ expressions
        // 在LINQ表达式中的新行中放置“in”
        private void Foo3()
        {
            var q1 = from i in l
                select i
                into j
                where j != 0
                select j;
        }
    }
}