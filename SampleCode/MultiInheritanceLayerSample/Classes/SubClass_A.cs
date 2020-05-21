using System;

namespace MultiInheritanceLayerSample.Classes
{
    public class SubClass_A : BaseClass
    {
        public SubClass_A()
        {
            Console.WriteLine("Invoke constructor of SubClass_A");
        }
        public override void Show()
        {
            Console.WriteLine("I am SubClass_A");
        }
    }
}
