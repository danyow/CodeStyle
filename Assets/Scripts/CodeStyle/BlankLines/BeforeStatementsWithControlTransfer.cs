using System;
using TMPro;
using UnityEngine;

namespace CodeStyle.BlankLines
{
    public class BeforeStatementsWithControlTransfer
    {
        private object Foo(string arg)
        {
            Debug.Log("Foo");
            if (arg == null) throw new ArgumentNullException();
            var smth = arg.ToIntArray();
            if (smth == null) return null;
            var smthElse = smth.ToString();
            return null;
        }
    }
}