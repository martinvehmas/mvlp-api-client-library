using System.Collections.Generic;

namespace MvLpApi.ClientLibrary.ApiModels
{
    public class FullStaffMember : StaffMember
    {
        public IEnumerable<StaffMemberGroup> Groups { get; set; }
    }
}
