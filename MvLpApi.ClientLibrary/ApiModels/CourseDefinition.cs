using System;
using System.Collections.Generic;
using System.Text;

namespace MvLpApi.ClientLibrary.ApiModels
{
    public class CourseDefinition
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsInternship { get; set; }
        public int Points { get; set; }
        public Subject Subject { get; set; }
    }
}
