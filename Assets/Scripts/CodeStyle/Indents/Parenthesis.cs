namespace CodeStyle.Indents
{
    /// <summary>
    /// 插入语?
    /// </summary>
    public class Parenthesis : Base
    {

        /// <summary>
        /// 在括号内使用连续行缩进
        /// </summary>
        // Use continuous line indent inside parenthesis
        private void UseContinuousLineIndentInsideParenthesis()
        {
            var x = Method(
                parameter1,
                parameter2
            );
        }

        /// <summary>
        /// 缩进方法声明括号
        /// </summary>
        // Indent method declarations' parenthesis
        public interface IIndentMethodDeclarationsParenthesis
        {
            void Method(
                int parameter1,
                int parameter2
            );
        }

        /// <summary>
        /// 缩进方法调用括号
        /// </summary>
        //     Indent method calls' parenthesis
        public void IndentMethodCallsParenthesis()
        {
            var x = Method(
                parameter1,
                parameter2
            );
        }


        /// <summary>
        /// 缩进语句 If While For Etc 括号
        /// </summary>
        //     Indent statement (if, while, for, etc) parenthesis
        public void IndentStatementIfWhileForEtcParenthesis()
        {
            if (
                condition1 &&
                condition2
            )
                return;
        }

        /// <summary>
        /// 缩进类型参数角度
        /// </summary>
        //     Indent type parameter's angles
        public interface IIndentTypeParametersAngles
        {
            void Method<
                T1,
                T2
            >();
        }

        /// <summary>
        /// 缩进类型参数角度
        /// </summary>
        //     Indent type argument's angles
        public void IndentTypeArgumentsAngles()
        {
            var x = Method<
                Class1,
                Class2
            >();
        }

        /// <summary>
        /// 缩进其他括号和括号
        /// </summary>
        //     Indent other parenthesis and brackets
        public void IndentOtherParenthesisAndBrackets()
        {
            var x = 1 * checked(
                5 +
                6
            );
        }
    }
}