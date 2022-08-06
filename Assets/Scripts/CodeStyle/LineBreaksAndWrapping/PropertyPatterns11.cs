namespace CodeStyle.LineBreaksAndWrapping
{
    // Arrangement of Property Patterns
    // 财产模式的安排
    public class PropertyPatterns11:Base
    {
        // Keep existing arrangement of property patterns
        // 保持现有的财产模式安排
        private void Foo1()
        {
            bool matches = sourceObject is MyType
                           {
                               F1: 1,
                               F2: 2
                           } &&
                           sourceObject is MyType { F1: 1, F2: 2 };
        }
        
        // Place simple property pattern on single line
        // 在单行上放置简单的属性模式
        private void Foo2()
        {
            bool matches = sourceObject is MyType { F1: 1, F2: 2 };
        }
        
        // Wrap property pattern
        // 包装特性模式
        private void Foo3()
        {
            bool matches =
                sourceObject is MyType
                {
                    F1: 1, F2: 2
                } &&
                sourceObject is MyType
                {
                    F1: 1,
                    F2: 2,
                    F3: 3,
                    F4: 4,
                    F5: 5,
                    F6: 6,
                    F7: 7,
                    F8: 8
                };
        }
    }
}