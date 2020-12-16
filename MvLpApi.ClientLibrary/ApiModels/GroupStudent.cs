using System;
using System.Collections.Generic;
using System.Text;

namespace MvLpApi.ClientLibrary.ApiModels
{
    public class GroupStudent
    {
        public StudentReference Student { get; set; }
        public IEnumerable<GroupRoleReference> GroupRoles { get; set; }
    }
}
