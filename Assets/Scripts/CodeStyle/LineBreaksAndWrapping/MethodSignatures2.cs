namespace CodeStyle.LineBreaksAndWrapping
{
    public class MethodSignatures2
    {
        // Wrap formal parameters
        interface IA
        {
            void M(int p1, int p2);

            void SomeMethod(
                int p1,
                int p2,
                int p3,
                int p4);
        }
        
        // Max formal parameters on a single line
        interface IA1
        {
            void M(int arg1);
            void M(int arg1, int arg2);
            void M(int arg1, int arg2, int arg3);
            void M(int arg1, int arg2, int arg3, int arg4);
            void M(int arg1, int arg2, int arg3, int arg4, int arg5);
            void M(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6);
            void M(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7);
            void M(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8);
            void M(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9);
        }
        // Keep existing arrangement of parenthesis in declaration
        void SomeMethod0(
            int p1,
            int p2,
            int p3,
            int p4
        )
        {
        }
        
        // Prefer wrap before "(" in declaration
        // Prefer wrap after ")" in declaration
        // Prefer wrap before "(" in declaration
        void SomeMethod(
            int p1,
            int p2,
            int p3,
            int p4)
        {
        }
        
        // Allow constructor initializer on the same line
        class C
        {
            public C() : base()
            {
            }
        }
    }
}