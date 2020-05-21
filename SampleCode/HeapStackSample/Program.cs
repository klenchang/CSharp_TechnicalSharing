using System;

namespace HeapStackSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var ca = new ClassA();
            SetName(ca);
            Console.WriteLine($"name in class = {ca.Name}");

            var sa = new StructA();
            SetName(sa);
            Console.WriteLine($"name in struct = {sa.Name}");

            Console.ReadKey();
        }
        public class ClassA
        {
            public string Name { get; set; }
        }
        public struct StructA
        {
            public string Name { get; set; }
        }
        private static void SetName(ClassA ca) => ca.Name = "Klen";
        private static void SetName(StructA ca) => ca.Name = "Klen";
    }
}
