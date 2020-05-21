using System;

namespace PEDConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PEDLibrary.Departments.BaseDepartment department = new PEDLibrary.Departments.PD();
                department.SetManager(PEDLibrary.Enums.PEDInternalMembers.Tarien, PEDLibrary.Enums.Managers.Klen, out string errorMsg);

                Console.WriteLine(department.Manager);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message : {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
