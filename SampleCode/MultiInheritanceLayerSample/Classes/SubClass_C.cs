using System;

namespace MultiInheritanceLayerSample.Classes
{
    public class SubClass_C : BaseClass
    {
        public SubClass_C()
        {
            Console.WriteLine("Invoke constructor of SubClass_C");
            Console.Write("Invoke Show() by SubClass_C constructor, result is ");
            Show();
        }
        public new virtual void Show() => Console.WriteLine("I am SubClass_C");
    }
}
