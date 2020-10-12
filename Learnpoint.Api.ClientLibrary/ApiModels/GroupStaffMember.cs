using System;
using System.Collections.Generic;
using System.Text;

namespace Learnpoint.Api.ClientLibrary.ApiModels
{
    public class GroupStaffMember
    {
        public StaffMemberReference StaffMember { get; set; }
        public bool IsGroupManager { get; set; }
        public IEnumerable<GroupRoleReference> GroupRoles { get; set; }
    }
}
