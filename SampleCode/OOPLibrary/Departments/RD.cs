using System;
using PEDLibrary.Interfaces;

namespace PEDLibrary.Departments
{
    internal class RD : BaseDepartment, IExplainServiceLogic, ICoding
    {
        public RD() => Manager = Enums.Managers.Klen;
        public RD(Enums.Managers manager) : base(manager) { }
        internal override string[] GetTeamMembers()
        {
            return new[] {
                "Klen", "Eva", "Hancle", "Jordan",
                "Michael", "Hadji", "Richard", "Jeff", "Elsha",
                "Melissa"
            };
        }
        internal override int GetTeamMemberCount() => 10;
        public void ExplainServiceLogic()
            => Console.WriteLine("Explain service logic by RD");
        public void Coding()
            => Console.WriteLine("Write code hardly");
    }
}
