using System;
using System.Collections.Generic;
using System.Text;

namespace Learnpoint.Api.ClientLibrary.ApiModels
{
    public class GroupsApiResponse
    {
        public string ApiVersion { get; set; }
        public GroupsData Data { get; set; }
        public ApiError Error { get; set; }
    }
}
