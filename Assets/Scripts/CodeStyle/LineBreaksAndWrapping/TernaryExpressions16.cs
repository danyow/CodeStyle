namespace CodeStyle.LineBreaksAndWrapping
{
    // Arrangement of Ternary Expressions
    // 三元表达式的排列
    public class TernaryExpressions16 : Base
    {

        // Prefer wrap before "?" and "." in ternary expressions
        // 更喜欢“？”之前的包装。还有“。”在三元表达式中
        private dynamic Foo1()
        {
            return hereGoesSomeBoolExpression
                ? returnThisIfTrue
                : returnThatIfFalse;
        }

        // Wrap ternary expression
        // 包装三元表达式
        private void Foo2()
        {
            myField = someCondition
                ? true
                : false;
        }

        // Nested ternary expression style
        // 嵌套三值表达式样式
        private void Foo3()
        {
            a = i ? "am" :
                you ? "are" : "is";

            b = error ? red :
                warning ? yellow :
                green;

            c = tiger ? dangerous :
                cat ? cute : boring;

            d = roses ? red :
                violets ? blue : so_are_you;
        }

    }
}