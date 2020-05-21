using Newtonsoft.Json.Linq;
using PEDLibrary.Departments;
using PEDLibrary.Interfaces;
using System;
using System.Linq;

namespace PEDLibrary
{
    public class PEDService
    {
        private BaseDepartment GetDepartmentInstance(Enums.Departments targetDepartmernt)
        {
            BaseDepartment department = null;
            switch (targetDepartmernt)
            {
                case Enums.Departments.RD:
                    department = new RD(Enums.Managers.Klen);
                    break;
                case Enums.Departments.PD:
                    department = new PD();
                    break;
                case Enums.Departments.CPD:
                    department = new CPD();
                    break;
                default:
                    throw new NotImplementedException("Sorry, we didn't build this department instance");
            }
            return department;
        }
        public string GetManagerName(Enums.Departments targetDepartment)
        {
            BaseDepartment department = GetDepartmentInstance(targetDepartment);

            //error because protected set
            //department.Manager = Enums.Managers.Jay;

            //but you can callback this function to set up new manager
            //string errorMsg = "";
            //var result = department.SetManager(Enums.PEDInternalMembers.Tarien, Enums.Managers.Klen, out errorMsg);

            return department.Manager.ToString();
        }
        public void ExplainServiceLogin(Enums.Departments targetDepartment)
        {
            IExplainServiceLogic service = null;
            if (targetDepartment == Enums.Departments.PD)
                service = new PD();
            else if (targetDepartment == Enums.Departments.RD)
                service = new RD();

            if (service != null) service.ExplainServiceLogic();
            else throw new NotImplementedException("Only RD and PD know the logic");
        }
        public void StartToIntegration(Enums.Departments targetDepartment)
        {
            if (targetDepartment != Enums.Departments.RD)
                throw new ArgumentException("Only RD can perform integration process");

            ICoding instance = new RD();
            instance.Coding();
        }
        public string GetDepartmentInfo(Enums.Departments targetDepartment)
        {
            BaseDepartment department = GetDepartmentInstance(targetDepartment);
            var information = new JObject
            {
                { "Supervisor", department.Supervisor.ToString() },
                { "Manager", department.Manager.ToString() },
                { "TeamMemberCount", department.GetTeamMemberCount() },
                { "TeamMembers", department.GetTeamMembers().Aggregate((result, next)=>$"{result},{next}")},
                { "TeamAssets", department.GetAssetsItems().Aggregate((result, next)=>$"{result},{next}") }
            };
            return information.ToString(Newtonsoft.Json.Formatting.None);
        }
    }
}
