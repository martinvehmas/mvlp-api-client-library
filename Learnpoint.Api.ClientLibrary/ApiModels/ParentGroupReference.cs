using System;
using System.Collections.Generic;
using System.Text;

namespace Learnpoint.Api.ClientLibrary.ApiModels
{
    public class ParentGroupReference
    {
        public GroupReference Group { get; set; }
        public ParentGroupReference ParentGroup { get; set; }
    }
}
