namespace CodeStyle.Indents
{
    /// <summary>
    /// 插入语?
    /// </summary>
    public class Parenthesis
    {
        /// <summary>
        /// 在括号内使用连续行缩进
        /// </summary>
        private void UseContinuousLineIndentInsideParenthesis()
        {
            var parameter1 = Imitation.Value<bool>();
            var parameter2 = Imitation.Value<bool>();

            var x = Imitation.Method(
                parameter1,
                parameter2
            );
        }

        /// <summary>
        /// 缩进方法声明括号
        /// </summary>
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
        public void IndentMethodCallsParenthesis()
        {
            UseContinuousLineIndentInsideParenthesis();
        }


        /// <summary>
        /// 缩进语句 If While For Etc 括号
        /// </summary>
        public void IndentStatementIfWhileForEtcParenthesis()
        {
            var condition1 = Imitation.Value<bool>();
            var condition2 = Imitation.Value<bool>();
            if (
                condition1 &&
                condition2
            )
                return;
        }

        /// <summary>
        /// 缩进类型参数角度
        /// </summary>
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
        public void IndentTypeArgumentsAngles()
        {
            var x = Imitation.Method<
                Class1,
                Class2
            >();
        }

        /// <summary>
        /// 缩进其他括号和括号
        /// </summary>
        public void IndentOtherParenthesisAndBrackets()
        {
            var x = 1 * checked(
                5 +
                6
            );
        }
    }
}