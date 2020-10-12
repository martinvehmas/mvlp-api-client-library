using System;
using System.Collections.Generic;
using System.Text;

namespace Learnpoint.Api.ClientLibrary.ApiModels
{
    public class StudentGroup
    {
        public GroupReference Group { get; set; }
        public IEnumerable<GroupRoleReference> GroupRoles { get; set; }
    }
}
