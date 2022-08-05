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
            var condition = Fake.Boolean();
            var condition1 = Fake.Boolean();

            if (condition)
            {
                if (condition1)
                {
                    Fake.Foo1();
                    Fake.Foo2();
                }
                else
                {
                    Fake.Foo3();
                    Fake.Foo4();
                }
            }
        }

        /// <summary>
        /// 连续行缩进倍数
        /// </summary>
        public void ContinuousLineIndentMultiplier()
        {
            var x = Fake.Foo1() +
                    Fake.Foo2();
            var y = Fake.Foo1() +
                    Fake.Foo2() +
                    Fake.Foo3() +
                    Fake.Foo4();
            var z =
                Fake.Foo1() +
                Fake.Foo2() +
                Fake.Foo3() +
                Fake.Foo4();
        }
    }
}