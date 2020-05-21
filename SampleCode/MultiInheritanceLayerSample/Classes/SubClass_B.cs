using System;

namespace MultiInheritanceLayerSample.Classes
{
    public class SubClass_B : BaseClass
    {
        public SubClass_B()
        {
            Console.WriteLine("Invoke constructor of SubClass_B");
            Console.Write("Invoke Show() by SubClass_B constructor, result is");
            Show();
        }
        //if add sealed in here, the SubClass_B_2 will not be able to override Show() of SubClass_B
        public override void Show() => Console.WriteLine("I am SubClass_B");
    }
}
