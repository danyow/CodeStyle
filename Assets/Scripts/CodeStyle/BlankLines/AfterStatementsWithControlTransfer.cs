using System;
using System.Linq;
using TMPro;

namespace CodeStyle.BlankLines
{
    public class AfterStatementsWithControlTransfer
    {
        private object Foo(string arg)
        {
            if (arg == null) throw new ArgumentNullException();
            var smth = arg.ToIntArray();
            if (smth == null) return null;
            var smthElse = smth.ToList();
            return null;
        }
    }
}