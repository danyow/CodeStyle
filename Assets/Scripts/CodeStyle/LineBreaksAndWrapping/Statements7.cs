using System;

namespace CodeStyle.LineBreaksAndWrapping
{


    public class Statements7 : Base
    {
        // Place " else" on new line
        private void P1()
        {
            if (condition)
            {
                foo();
            }
            else
            {
                foo();
            }
        }

        // Place "while" on new line
        private void P2()
        {
            do
            {
                foo();
            } while (condition);
        }
        // Place "catch" on new line

        private void P3()
        {
            try
            {
                foo();
            }
            catch (Exception e)
            {
                foo();
            }
            finally
            {
                foo();
            }
        }

        // Place "finally" on new line
        // Wrap "for" statement header
        private void P5()
        {
            for (int i = initial;
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