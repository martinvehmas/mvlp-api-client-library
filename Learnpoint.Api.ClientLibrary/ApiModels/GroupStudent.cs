using System;
using System.Collections.Generic;
using System.Text;

namespace Learnpoint.Api.ClientLibrary.ApiModels
{
    public class GroupStudent
    {
        public StudentReference Student { get; set; }
        public IEnumerable<GroupRoleReference> GroupRoles { get; set; }
    }
}
