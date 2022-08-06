using System;

namespace CodeStyle.LineBreaksAndWrapping
{
    // Arrangement of Embedded Blocks
    // 嵌入块的排列
    public class EmbeddedBlocks9: Base
    {
        // Keep existing arrangement of embedded blocks
        // 保持嵌入块的现有排列
        void Foo()
        {
            if (condition)
            {
                DoSomething();
            }
            if (condition1)
            {
                DoSomething1();
            }
        }
        
        
        // Place a block with a single simple statement on the same line
        // 在同一行中放置一个具有单个简单语句的块
        void Foo1()
        {
            if (condition)
            {
                DoSomething();
            }
        }
        
        // Place simple anonymous method on single line 
        // 在单行上放置简单的匿名方法
        void Foo2()
        {
            EventHandler e = delegate { return; };
        }

    }
}