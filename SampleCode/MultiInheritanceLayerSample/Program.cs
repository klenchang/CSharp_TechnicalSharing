using System;
using MultiInheritanceLayerSample.Classes;

namespace MultiInheritanceLayerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scenario 1
            Console.WriteLine("Scenario 1 : SubClass_A override Show() of BaseClass");
            Console.WriteLine("==================================================");
            BaseClass sa = new SubClass_A();
            Console.Write("Invoke Show() by sa, result is ");
            sa.Show();
            Console.WriteLine("==================================================");
            Console.WriteLine("Scenario 1 end");
            Console.WriteLine();

            //Scenario 2
            Console.WriteLine("Scenario 2 : ");
            Console.WriteLine("SubClass_B override Show() of BaseClass");
            Console.WriteLine("SubClass_B_2 override Show() of SubClass_B");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Start from first layer SubClass_B");
            BaseClass sb = new SubClass_B();
            Console.Write("Invoke Show() by sb, result is ");
            sb.Show();
            Console.WriteLine("End of 1.");
            Console.WriteLine("------------------------");
            Console.WriteLine("2. Start from Second layer SubClass_B_2");
            BaseClass sb2 = new SubClass_B_2();
            Console.Write("Invoke Show() by sb2, result is ");
            sb2.Show();
            Console.WriteLine("End of 2.");
            Console.WriteLine("==================================================");
            Console.WriteLine("Scenario 2 end");
            Console.WriteLine();

            //Scenario 3
            Console.WriteLine("Scenario 3 : ");
            Console.WriteLine("SubClass_C create a new virtual Show() of BaseClass");
            Console.WriteLine("SubClass_C_2 override Show() of SubClass_C");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Start from first layer SubClass_C");
            BaseClass sc = new SubClass_C();
            Console.Write("Invoke Show() by sc, result is ");
            sc.Show();
            Console.WriteLine("End of 1.");
            Console.WriteLine("------------------------");
            Console.WriteLine("2. Start from Second layer SubClass_C_2");
            BaseClass sc2 = new SubClass_C_2();
            Console.Write("Invoke Show() by sc2, result is ");
            sc2.Show();
            Console.WriteLine("End of 2.");
            Console.WriteLine("==================================================");
            Console.WriteLine("Scenario 3 end");
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
