using UnityEngine;

namespace CodeStyle.BlankLines
{
    public class BeforeStatementsWitchChildBlocks
    {
        private string Foo(string arg)
        {
            Debug.Log("Foo");
            if (arg == "A")
            {
                Imitation.DoSomething();
                Imitation.DoSomethingElse();
            }
            Imitation.DoMoreThings();
            return null;
        }
    }
    
    public class AfterStatementsWitchChildBlocks
    {
        private string Foo(string arg)
        {
            Debug.Log("Foo");
            if (arg == "A")
            {
                Imitation.DoSomething();
                Imitation.DoSomethingElse();
            }
            Imitation.DoMoreThings();
            return null;
        }
    }
}