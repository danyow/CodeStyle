namespace CodeStyle.BlankLines
{
    public class CaseSectionWithABlockInSwitchStatement
    {

        private void Around()
        {
            var a = Imitation.Value<int>();

            switch (a)
            {
                case 1:
                {
                    Imitation.Foo1();
                    break;
                }
                case 2:
                {
                    Imitation.Foo2();
                    break;
                }
                default:
                {
                    Imitation.Foo3();
                    break;
                }
            }
        }
    }
    
    public class MultilineCaseSectionInSwitchStatement
    {

        private void Around()
        {
            var a = Imitation.Value<int>();

            switch (a)
            {
                case 1:
                    Imitation.Foo1();
                    break;
                case 2:
                    Imitation.Foo2();
                    break;
                default:
                    Imitation.Foo3();
                    break;
            }
        }
    }
}