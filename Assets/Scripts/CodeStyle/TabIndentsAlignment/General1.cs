// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable LocalVariableHidesMember
// ReSharper disable UnusedVariable
// ReSharper disable InvertIf

namespace CodeStyle.TabIndentsAlignment // 制表符缩进对齐
{
    public class General1 : Base
    {
        [Settings(@"Indent style")]
        [Tanslate(@"缩进样式")]
        public void Foo1()
        {
            if (condition)
            {
                if (condition1)
                {
                    foo1();
                    foo2();
                }
                else
                {
                    foo3();
                    foo4();
                }
            }
        }

        [Settings(@"Indent size")]
        public void Foo2()
        {
            if (condition)
            {
                if (condition1)
                {
                    foo1();
                    foo2();
                }
                else
                {
                    foo3();
                    foo4();
                }
            }


        }

        [Settings(@"Tab width")]
        public void Foo3()
        {
            if (condition)
            {
                if (condition1)
                {
                    foo1();
                    foo2();
                }
                else
                {
                    foo3();
                    foo4();
                }
            }


        }

        [Settings(@"Continuous line indent multiplier")]
        public void Foo4()
        {
            int x = foo1() +
                    foo2();
        }
    }
}