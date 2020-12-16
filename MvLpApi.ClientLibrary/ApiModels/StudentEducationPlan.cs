using System;
using System.Collections.Generic;
using System.Text;

namespace MvLpApi.ClientLibrary.ApiModels
{
    public class StudentEducationPlan
    {
        public IEnumerable<EducationPlan> Parts { get; set; }
        public StudentEducationPlanState State { get; set; }
    }
}
