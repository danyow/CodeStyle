using System;

namespace CodeStyle
{
    public class Base
    {
        protected dynamic a;
        protected dynamic b;
        protected dynamic c;
        protected dynamic d;
        protected dynamic e;
        protected dynamic aa;
        protected dynamic bb;
        protected dynamic x;
        protected dynamic y;
        protected dynamic z;
        protected dynamic op;
        protected dynamic[] xs;
        protected dynamic xx;
        protected dynamic xxx;
        protected dynamic xxxxx;
        protected dynamic xxxxxxx;
        protected dynamic zzz;
        protected dynamic foo;
        protected dynamic foo1;
        protected dynamic foo2;
        protected dynamic foo3;
        protected dynamic foo4;
        protected dynamic fooCall;
        protected dynamic param1;
        protected dynamic param2;
        protected dynamic firstParameter;
        protected dynamic secondParameter;
        protected dynamic sourceObject;
        protected dynamic destination;
        protected dynamic source1;
        protected dynamic source2;
        protected dynamic source3;
        protected const dynamic someOperand = null;
        protected const dynamic operand2 = null;
        protected const dynamic operand3 = null;
        protected const dynamic operand4 = null;
        protected dynamic condition;
        protected dynamic condition1;
        protected dynamic condition2;
        protected dynamic someCondition;
        protected dynamic otherCondition;
        protected dynamic parameter1;
        protected dynamic parameter2;
        protected dynamic expression;
        protected dynamic MyVar;
        protected dynamic SomeMyMethod;
        protected dynamic DoSomething;
        protected dynamic DoSomethingElse;
        protected dynamic DoMoreThings;
        protected dynamic SomeMethod;
        protected dynamic OtherMethod;
        protected dynamic ThirdMethod;
        protected static dynamic CallMe;

        public static T Value<T>()
        {
            return default;
        }

        public dynamic Method(params dynamic[] p)
        {
            return default;
        }

        public static void FooCall(Func<int> callback)
        {

        }


        public static int Method<T1, T2>(params object[] parameter)
        {
            return 0;
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

        public class BaseClass
        {

        }

        public interface I1
        {

        }

        public interface I2
        {

        }

        public interface I3
        {

        }

        public interface I4
        {

        }

        public interface IMyInterface
        {
            int Prop1 { get; set; }
            int Prop2 { get; set; }
        }

        public interface IMyInterface2 : IMyInterface
        {

        }

        public interface IMyInterface3 : IMyInterface
        {

        }

        public class MyType
        {
            public int Field1;
            public int Field2;
            public int FShort;
            public int FieldLongLong;
        }

        public interface ISomeInterface
        {

        }

        public struct ImitationStruct
        {
            public static ImitationStruct? SomeMethod()
            {
                return default;
            }

            public ImitationStruct OtherMethod()
            {
                return default;
            }

            public ImitationStruct ThirdMethod()
            {
                return default;
            }
        }

        public class StudentName
        {
            public string FirstName;
            public string LastName;
            public int ID;
        }

        public enum Op
        {
            Add,
            Subtract,
            Multiply,
            Divide,
        }

        public enum MyEnum
        {
            MyConstant,
        }

        public class AttributeAttribute : Attribute
        {
            public AttributeAttribute(params object[] ps)
            {

            }
        }


        public class AttrAttribute : Attribute
        {
            public AttrAttribute(params object[] ps)
            {

            }
        }

        public class Attr1Attribute : Attribute
        {
            public Attr1Attribute(params object[] ps)
            {

            }
        }

        public class Attr2Attribute : Attribute
        {
            public Attr2Attribute(params object[] ps)
            {

            }
        }

        public class Attr3Attribute : Attribute
        {
            public Attr3Attribute(params object[] ps)
            {

            }
        }

        public class MoreThen
        {
            public static bool operator >(MoreThen a, string b)
            {
                return false;
            }

            public static bool operator <(MoreThen a, string b)
            {
                return false;
            }
        }
    }
}