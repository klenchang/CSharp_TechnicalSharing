using System;

namespace MultiInheritanceLayerSample.Classes
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Invoke constructor of Base");
            Console.Write("Invoke Show() by BaseClass constructor, result is ");
            Show();
        }
        public virtual void Show() => Console.WriteLine("I am BaseClass");
    }
}
