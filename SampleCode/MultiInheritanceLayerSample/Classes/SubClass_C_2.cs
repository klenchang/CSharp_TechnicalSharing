using System;

namespace MultiInheritanceLayerSample.Classes
{
    public class SubClass_C_2 : SubClass_C
    {
        public SubClass_C_2()
        {
            Console.WriteLine("Invoke constructor of SubClass_C_2");
        }
        public override void Show() => Console.WriteLine("I am SubClass_C_2");
    }
}
