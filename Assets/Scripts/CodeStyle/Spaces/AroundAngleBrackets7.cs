namespace CodeStyle.Spaces
{
    // Around Angle Brackets
    public class AroundAngleBrackets7: Base
    {
        // Before type parameter list angle
        class C<T1, T2>
        {
        }
        // Before type argument list angle
        private void Foo2()
        {
            Method<int>();
        }
        // Type parameter angles
        class C1<T1, T2>
        {
        }
        // Type argument angles
        private void Foo4()
        {
            Method<int>();
        } 
    }
}