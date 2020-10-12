using System;
using System.Collections.Generic;
using System.Text;

namespace Learnpoint.Api.ClientLibrary.ApiModels
{
    public class StudentsData
    {
        public IEnumerable<FullStudent> Students { get; set; }
        public StudentsReferenceData ReferenceData { get; set; }
    }
}
