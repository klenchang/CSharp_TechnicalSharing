namespace PEDLibrary.Departments
{
    internal class CPD : BaseDepartment
    {
        public CPD()
        {
            Manager = Enums.Managers.Weber;
        }
        internal override int GetTeamMemberCount() => 10;
        internal override string[] GetTeamMembers() => new[] { "Jerry", "Others" };
        internal override string[] GetAssetsItems() => new[] { "Computer", "U shield" };
    }
}
