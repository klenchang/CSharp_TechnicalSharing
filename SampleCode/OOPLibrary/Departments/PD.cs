using PEDLibrary.Enums;
using PEDLibrary.Interfaces;
using System;

namespace PEDLibrary.Departments
{
    internal class PD : BaseDepartment, IExplainServiceLogic
    {
        public PD()
        {
            //base is dark means you can omit it.
            base.Manager = Managers.Jay;
        }
        public void ExplainServiceLogic()
        {
            Console.WriteLine("Explain service logic by PD");
        }
        internal override int GetTeamMemberCount() => 3;
        internal override string[] GetTeamMembers() => new[] { "Jay", "Cathy", "Stephanie" };
    }
}
