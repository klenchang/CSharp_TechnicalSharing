using System;

namespace UBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var pedService = new PEDLibrary.PEDService();
                var department = PEDLibrary.Enums.Departments.RD;
                Console.WriteLine($"Current Department : {department}");
                Console.WriteLine();

                var departmentInfo = pedService.GetDepartmentInfo(department);
                Console.WriteLine($"Department Information : {departmentInfo}");
                Console.WriteLine();

                var managerName = pedService.GetManagerName(department);
                Console.WriteLine($"{department} manager's name : {managerName}");
                Console.WriteLine();

                Console.WriteLine($"Ask {department} to explain the ped service logic");
                pedService.ExplainServiceLogin(department);
                Console.WriteLine();

                Console.WriteLine($"Ask {department} to start to do integration with company");
                pedService.StartToIntegration(department);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
