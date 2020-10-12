using System.Collections.Generic;

namespace Learnpoint.Api.ClientLibrary.ApiModels
{
    public class StaffMembersReferenceData
    {
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<GroupRole> GroupRoles { get; set; }
    }
}