namespace CodeStyle.LineBreaksAndWrapping
{
    // Arrangement of Initializers
    // 初始器的排列
    public class Initializers12 : Base
    {
        // Keep existing arrangement of initializers
        // 保持现有的初始设置
        private void Foo1()
        {
            var result = new
            {
                A = 0
            };
            var result1 = new
            {
                A = 0
            };
        }
        // Place simple array, object and collection on single line 
        // 将简单的数组、对象和集合放在单行上。
        private void Foo2()
        {
            var result = new
            {
                A = 0
            };
        }
        // Max object and collection initializer elements on a single line
        // 单行上的MAX对象和集合初始化元素
        private void Foo3()
        {
            x = new C()
            {
                Prop1 = 1
            };
            x = new C()
            {
                Prop1 = 1, Prop2 = 1
            };
            x = new C()
            {
                Prop1 = 1, Prop2 = 1, Prop3 = 1
            };
            x = new C()
            {
                Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1
            };
            x = new C()
            {
                Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1,
                Prop5 = 1
            };
            x = new C()
            {
                Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1,
                Prop5 = 1, Prop6 = 1
            };
            x = new C()
            {
                Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1,
                Prop5 = 1, Prop6 = 1, Prop7 = 1
            };
            x = new C()
            {
                Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1,
                Prop5 = 1, Prop6 = 1, Prop7 = 1, Prop8 = 1
            };
            x = new C()
            {
                Prop1 = 1, Prop2 = 1, Prop3 = 1, Prop4 = 1,
                Prop5 = 1, Prop6 = 1, Prop7 = 1, Prop8 = 1,
                Prop9 = 1
            };
        }
        // Wrap object and collection initializer
        // 包装对象和集合初始化程序
        private void Foo4()
        {
            new C()
            {
                PropertyX = 1,
                PropertyY = 2,
                PropertyZ = 3
            };
        }
        
        // Max array initializer elements on a single line
        // 单行上的最大数组初始化元素

        private void Foo5()
        {
            x = new[] { val1 };
            x = new[] { val1, val2 };
            x = new[] { val1, val2, val3 };
            x = new[] { val1, val2, val3, val4 };
            x = new[] { val1, val2, val3, val4, val5 };
            x = new[] { val1, val2, val3, val4, val5, val6 };
            x = new[] { val1, val2, val3, val4, val5, val6, val7 };
            x = new[] { val1, val2, val3, val4, val5, val6, val7, val8 };
            x = new[] { val1, val2, val3, val4, val5, val6, val7, val8, val9 };
        }
        
        // Wrap array initializer
        // 换行数组初始化器
        private void Foo6()
        {
            var a = new C[]
            {
                Element1,
                ElementX,
                ElementY,
                ElementZ,
                ElementZzz
            };
        }
    }
}