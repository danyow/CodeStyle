using System.Diagnostics.CodeAnalysis;

namespace CodeStyle.Indents
{
    /// <summary>
    /// 一般的
    /// </summary>
    public class General
    {
        /// <summary>
        /// 缩进样式
        /// </summary>
        public void IndentStyle()
        {
            var condition = Imitation.Value<bool>();
            var condition1 = Imitation.Value<bool>();

            if (condition)
            {
                if (condition1)
                {
                    Imitation.Foo1();
                    Imitation.Foo2();
                }
                else
                {
                    Imitation.Foo3();
                    Imitation.Foo4();
                }
            }
        }

        /// <summary>
        /// 连续行缩进倍数
        /// </summary>
        public void ContinuousLineIndentMultiplier()
        {
            var x = Imitation.Foo1() +
                    Imitation.Foo2();
            var y = Imitation.Foo1() +
                    Imitation.Foo2() +
                    Imitation.Foo3() +
                    Imitation.Foo4();
            var z =
                Imitation.Foo1() +
                Imitation.Foo2() +
                Imitation.Foo3() +
                Imitation.Foo4();
        }
    }
}