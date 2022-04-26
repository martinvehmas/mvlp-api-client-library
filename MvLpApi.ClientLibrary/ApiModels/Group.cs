using System;
using System.Collections.Generic;

namespace MvLpApi.ClientLibrary.ApiModels
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime? LifespanFrom { get; set; }
        public DateTime? LifespanUntil { get; set; }
        public GroupCategory Category { get; set; }
        public ParentGroupReference ParentGroup { get; set; }
        public IEnumerable<ExtendedProperty> ExtendedProperties { get; set; }

        public class ExtendedProperty
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

    }
}
