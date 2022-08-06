namespace CodeStyle.BlankLines
{
    public class BeforeCaseInSwitchStatement
    {
        private int Method()
        {
            var a = Imitation.Value<int>();
            var x = Imitation.Value<int>();
            var y = Imitation.Value<int>();
            
            switch (a)
            {
                case 1:  return x;
                case 2:  return y;
                default: return 0;
            }
        }
    }
    
    
    public class AfterCaseInSwitchStatement
    {
        private void Method()
        {
            var a = Imitation.Value<int>();
            
            switch (a)
            {
                case 1:
                    Imitation.Foo1();
                    Imitation.Foo2();
                    break;
                case 2:
                    Imitation.Foo1();
                    Imitation.Foo2();
                    break;
                default:
                    Imitation.Foo1();
                    Imitation.Foo2();
                    break;
            }
        }
    }
}