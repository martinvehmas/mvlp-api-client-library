using System.Collections.Generic;

namespace MvLpApi.ClientLibrary.ApiModels
{
    public class StaffMemberGroup
    {
        public GroupReference Group { get; set; }
        public bool IsGroupManager { get; set; }
        public IEnumerable<GroupRoleReference> GroupRoles { get; set; }
    }
}
