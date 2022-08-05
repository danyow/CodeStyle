using System;

namespace CodeStyle
{

    public static class Fake
    {
        public static int Foo1()
        {
            return 0;
        }

        public static int Foo2()
        {
            return 0;
        }

        public static int Foo3()
        {
            return 0;
        }

        public static int Foo4()
        {
            return 0;
        }

        public static bool Boolean()
        {
            return UnityEngine.Random.Range(0, 1) % 2 == 0;
        }

        public static int[] Array()
        {
            return new int[]
            {
            };
        }

        public static int Method(params object[] parameter)
        {
            return 0;
        }

        public static int Method<T1, T2>(params object[] parameter)
        {
            return 0;
        }
    }

    public class A : IDisposable
    {

        public void Dispose()
        {

        }
    }

    public class B : IDisposable
    {

        public void Dispose()
        {

        }
    }

    public class C : IDisposable
    {

        public void Dispose()
        {

        }
    }

    public class Class1
    {

    }

    public class Class2
    {

    }
}