namespace CodeStyle.LineBreaksAndWrapping
{
    public class ArrangementOfEmbeddedStatements
    {
        // Keep existing arrangement of embedded statements
        dynamic condition = Imitation.Value<dynamic>();
        dynamic condition1 = Imitation.Value<dynamic>();
        private void P()
        {
            
            if (condition) Imitation.DoSomething();
            if (condition1)
                Imitation.DoSomething();
        }
        // Place simple embedded statement on the same line
        private void P2()
        {
            if (condition)
                Imitation.DoSomething();
            if (condition && // comment
                condition1)
                Imitation.DoSomething();
        }
        // Place simple ”case” statement on the same line
        private dynamic P3()
        {
            var foo = Imitation.Value<dynamic>();
            var a = Imitation.Value<dynamic>();
            switch (foo)
            {
                case 1:
                    return a;
                case 2:
                case 3:
                    return a;
            }

            return null;
        }
    }
}