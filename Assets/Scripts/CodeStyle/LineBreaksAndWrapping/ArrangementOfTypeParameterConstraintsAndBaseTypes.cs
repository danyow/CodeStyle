using System.Collections;

namespace CodeStyle.LineBreaksAndWrapping
{
    public class ArrangementOfTypeParameterConstraintsAndBaseTypes
    {
        // Allow type constraints on the same line
        class C<T> where T : IEnumerable
        {
        }
        // Prefer wrap before first constraint
        // Wrap multiple type parameter constraints
        class C<T1, T2, T3> where T1 : I1
            where T2 : new()
            where T3 : class
        {
            
        }
        
        // Prefer wrap before type parameters opening angle
        class C<Type1, Type2,
            Type3, Type4>
        {
        }
        // Prefer wrap before ":"
        class Derived : BaseClass, I1,
            I2,
            I3, I4
        {
        }
        // Wrap extends/implements list
        class Derived1 : BaseClass, I1,
            I2, I3, I4
        {
        }
    }
}