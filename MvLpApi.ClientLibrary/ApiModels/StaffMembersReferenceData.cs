using System.Collections.Generic;

namespace MvLpApi.ClientLibrary.ApiModels
{
    public class StaffMembersReferenceData
    {
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<GroupRole> GroupRoles { get; set; }
    }
}