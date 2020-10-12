using System.Collections.Generic;

namespace Learnpoint.Api.ClientLibrary.ApiModels
{
    public class FullStaffMember : StaffMember
    {
        public IEnumerable<StaffMemberGroup> Groups { get; set; }
    }
}
