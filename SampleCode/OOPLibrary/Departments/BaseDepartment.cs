namespace PEDLibrary.Departments
{
    internal abstract class BaseDepartment
    {
        internal BaseDepartment() { }
        protected BaseDepartment(Enums.Managers manager)
        {
            Manager = manager;
        }
        private Enums.PEDInternalMembers _supervisor = Enums.PEDInternalMembers.Tarien;
        internal Enums.PEDInternalMembers Supervisor
        {
            get { return _supervisor; }
        }
        public Enums.Managers Manager { get; protected set; }
        internal bool SetManager(Enums.PEDInternalMembers currentUser, Enums.Managers newManager, out string errorMsg)
        {
            errorMsg = "";
            if (currentUser != _supervisor)
            {
                errorMsg = "Only supervisor can assign manager";
                return false;
            }
            Manager = newManager;

            return true;
        }
        internal abstract string[] GetTeamMembers();
        internal virtual string[] GetAssetsItems() => new[] { "Computer" };
        internal abstract int GetTeamMemberCount();
    }
}
