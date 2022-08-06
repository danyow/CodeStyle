namespace CodeStyle.BlankLines
{
    public class BeforeMultilineStatements
    {
        private string Foo(string arg)
        {
            var y = Imitation.Value<dynamic[]>();
            Imitation.DoSomething();
            foreach (var x in y)
            {
                x.DoSomething();
                x.DoSomethingElse();
            }
            Imitation.DoSomething();
            foreach (var x in y)
                x.DoSomething();
            Imitation.DoSomething();
            Imitation.SomeMyMethod(
                1,
                2);
            Imitation.DoSomething();

            return null;
        }
    }
    
    public class AfterMultilineStatements
    {
        private string Foo(string arg)
        {
            var y = Imitation.Value<dynamic[]>();
            Imitation.DoSomething();
            foreach (var x in y)
            {
                x.DoSomething();
                x.DoSomethingElse();
            }
            Imitation.DoSomething();
            foreach (var x in y)
                x.DoSomething();
            Imitation.DoSomething();
            Imitation.SomeMyMethod(
                1,
                2);
            Imitation.DoSomething();

            return null;
        }
    }
}