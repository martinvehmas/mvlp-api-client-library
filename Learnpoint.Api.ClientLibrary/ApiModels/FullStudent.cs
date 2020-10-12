using System;
using System.Collections.Generic;
using System.Text;

namespace Learnpoint.Api.ClientLibrary.ApiModels
{
    public class FullStudent : Student
    {
        public IEnumerable<StudentGroup> Groups { get; set; }
        public IEnumerable<StudentEducationPlan> EducationPlans { get; set; }
    }
}
