// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable LocalVariableHidesMember
// ReSharper disable UnusedVariable
// ReSharper disable UnusedMember.Local
// ReSharper disable ConvertToUsingDeclaration
// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable RedundantJumpStatement

#pragma warning disable CS0219
namespace CodeStyle.TabIndentsAlignment
{
    [Settings(@"Parenthesis")]
    [Tanslate(@"插入语?")]
    public class Parenthesis3 : Base
    {
        [Settings(@"Use continuous line indent inside parenthesis")]
        [Tanslate(@"在括号内使用连续行缩进")]
        private void UseContinuousLineIndentInsideParenthesis()
        {
            var x = Method(
                parameter1,
                parameter2
            );
        }


        [Settings(@"Indent method declarations' parenthesis")]
        [Tanslate(@"缩进方法声明括号")]
        public interface IIndentMethodDeclarationsParenthesis
        {
            void Method(
                int parameter1,
                int parameter2
            );
        }


        [Settings(@"Indent method calls' parenthesis")]
        [Tanslate(@"缩进方法调用括号")]
        public void IndentMethodCallsParenthesis()
        {
            var x = Method(
                parameter1,
                parameter2
            );
        }


        [Settings(@"Indent statement (if, while, for, etc) parenthesis")]
        [Tanslate(@"缩进语句 If While For Etc 括号")]
        public void IndentStatementIfWhileForEtcParenthesis()
        {
            if (
                condition1 &&
                condition2
            )
                return;
        }


        [Settings(@"Indent type parameter's angles")]
        [Tanslate(@"缩进类型参数角度")]
        public interface IIndentTypeParametersAngles
        {
            void Method<
                T1,
                T2
            >();
        }


        [Settings(@"Indent type argument's angles")]
        [Tanslate(@"缩进类型参数角度")]
        public void IndentTypeArgumentsAngles()
        {
            var x = Method<
                Class1,
                Class2
            >();
        }


        [Settings(@"Indent other parenthesis and brackets")]
        [Tanslate(@"缩进其他括号和括号")]
        public void IndentOtherParenthesisAndBrackets()
        {
            var x = 1 * checked(
                5 +
                6
            );
        }
    }
}