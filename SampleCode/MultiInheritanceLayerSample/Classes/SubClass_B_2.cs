using System;

namespace MultiInheritanceLayerSample.Classes
{
    public class SubClass_B_2 : SubClass_B
    {
        public SubClass_B_2()
        {
            Console.WriteLine("Invoke constructor of SubClass_B_2");
        }
        public override void Show() => Console.WriteLine("I am SubClass_B_2");
    }
}
