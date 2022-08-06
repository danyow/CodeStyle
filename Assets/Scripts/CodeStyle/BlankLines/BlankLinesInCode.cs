using System;

namespace CodeStyle.BlankLines
{
    

    public class BlankLinesInCode : Base
    {
        // Keep max blank lines in code
        void Method()
        {
            foo();


            foo();
        }

        
        // Remove blank lines after "{" and before "}”in code
        void Method1()
        {

            foo();
            foo();

        }
        
        // Around local function
        void Method2()
        {
            void LocalFunction1()
            {
                foo();
                foo2();
            }

            void LocalFunction2()
            {
                foo();
                foo2();
            }
        }
        
        // Around single line local function
        void Method4()
        {
            void LocalFunction1() { }
            void LocalFunction2() { }
        }
        
        // Before statements with control transfer
        dynamic Foo(string args)
        {
            Logger.Log("Foo");
            if (arg == null) throw new ArgumentNullException();
            var smth = arg.GetSomething();
            if (smth == null) return null;
            var smthElse = smth.GetSomethingElse();
            return null;
        }
        
        // After statements with control transfer
        dynamic Foo2(string args)
        {
            if (arg == null) throw new ArgumentNullException();
            var smth = arg.GetSomething();
            if (smth == null) return null;
            var smthElse = smth.GetSomethingElse();
            return null;
        }
        
        // Before statements with child blocks
        string Foo3(string arg)
        {
            Logger.Log("Foo");
            if (arg == "A")
            {
                DoSomething();
                DoSomethingElse();
            }
            DoMoreThings();
            return null;
        }
        
        // After statements with child blocks
        string Foo4(string arg)
        {
            Logger.Log("Foo");
            if (arg == "A")
            {
                DoSomething();
                DoSomethingElse();
            }
            DoMoreThings();
            return null;
        }
        
        // After multiline statements
        string Foo5(string arg)
        {
            DoSomething();
            foreach (var x in y)
            {
                x.DoSomething();
                x.DoSomethingElse();
            }
            DoSomething();
            foreach (var x in y)
                x.DoSomething();
            DoSomething();
            DoSomething(
                1,
                2);
            DoSomething();
            return null;
        }
        
        // Before multiline statements
        string Foo6(string arg)
        {
            DoSomething();
            foreach (var x in y)
            {
                x.DoSomething();
                x.DoSomethingElse();
            }
            DoSomething();
            foreach (var x in y)
                x.DoSomething();
            DoSomething();
            DoSomething(
                1,
                2);
            DoSomething();
            return null;
        }

        // Around "case" section with a block in switch statement
        void Foo7()
        {
            switch (a)
            {
                case 1:
                {
                    DoThis();
                    DoThat();
                    break;
                }
                case 2:
                {
                    DoIt();
                    DoItAgainWithLove();
                    break;
                }
                default:
                {
                    DoNothing();
                    DoSomething();
                    break;
                }
            }
        }

        // Around multiline”case" section in switch statement
        void Foo8()
        {
            switch (a)
            {
                case 1:
                    DoThis();
                    break;
                case 2:
                    DoThat();
                    break;
                default:
                    DoNothing();
                    break;
            }
        }

        // Before " case" in switch statement
        dynamic Foo9()
        {
            switch (a)
            {
                case 1:  return x;
                case 2:  return y;
                default: return 0;
            }
        }

        // After "case" in switch statement
        void Foo10()
        {
            switch (a)
            {
                case 1:
                    DoThis();
                    DoThat();
                    break;
                case 2:
                    DoIt();
                    DoItAgainWithLove();
                    break;
                default:
                    DoNothing();
                    DoSomething();
                    break;
            }
        }
    }
}