using System;

namespace CodeStyle.LineBreaksAndWrapping
{
    
    
    public class ArrangementOfStatements
    {
        private readonly dynamic condition = Imitation.Value<dynamic>();
        // Place " else" on new line
        private void P1()
        {
            if (condition)
            {
                Imitation.Foo1();
            }
            else
            {
                Imitation.Foo1();
            }
        }
        
        // Place "while" on new line
        private void P2()
        {
            do
            {
                Imitation.Foo1();
            } while (condition);
        }
        // Place "catch" on new line

        private void P3()
        {
            try
            {
                Imitation.Foo1();
            }
            catch (Exception e)
            {
                Imitation.Foo1();
            }
            finally
            {
                Imitation.Foo1();
            }
        }
        // Place "finally" on new line
        // Wrap "for" statement header
        private void P5()
        {
            var initial = Imitation.Value<int>();
            var loopLimit= Imitation.Value<int>();
            for (var i = initial;
                 i < loopLimit;
                 i++)
            {
            }
        }
        
        // Wrap multiple declaration
        class C
        {
            public int i = 0,
                j = 0,
                k = 2,
                l = 3,
                m = 4,
                n = 5;
        }

    }
}