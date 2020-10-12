using System.Collections.Generic;

namespace Learnpoint.Api.ClientLibrary.ApiModels
{
    public class StaffMembersData
    {
        public IEnumerable<FullStaffMember> StaffMembers { get; set; }
        public StaffMembersReferenceData ReferenceData { get; set; }
    }
}