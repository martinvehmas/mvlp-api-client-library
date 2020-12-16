using System;
using System.Collections.Generic;
using System.Text;

namespace MvLpApi.ClientLibrary.ApiModels
{
    public class EducationPlan
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public EducationPlanType Type { get; set; }
    }
}
