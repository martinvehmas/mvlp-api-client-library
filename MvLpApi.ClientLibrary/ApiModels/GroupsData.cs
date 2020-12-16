using System;
using System.Collections.Generic;
using System.Text;

namespace MvLpApi.ClientLibrary.ApiModels
{
    public class GroupsData
    {
        public IEnumerable<FullGroup> Groups { get; set; }
        public IEnumerable<FullGroup> ParentGroups { get; set; }
        public GroupsReferenceData ReferenceData { get; set; }

        public class GroupsReferenceData
        {
            public IEnumerable<StaffMember> StaffMembers { get; set; }
            public IEnumerable<Student> Students { get; set; }
            public IEnumerable<CourseDefinition> CourseDefinitions { get; set; }
            public IEnumerable<GroupRole> GroupRoles { get; set; }
        }
    }
}
