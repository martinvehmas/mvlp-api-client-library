using System;
using System.Collections.Generic;
using System.Text;

namespace Learnpoint.Api.ClientLibrary.ApiModels
{
    public class StudentsApiResponse
    {
        public string ApiVersion { get; set; }
        public StudentsData Data { get; set; }
        public ApiError Error { get; set; }
    }
}
