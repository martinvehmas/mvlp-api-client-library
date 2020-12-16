using System;
using System.Collections.Generic;
using System.Text;

namespace MvLpApi.ClientLibrary.ApiModels
{
    public class StudentGroup
    {
        public GroupReference Group { get; set; }
        public IEnumerable<GroupRoleReference> GroupRoles { get; set; }
    }
}
