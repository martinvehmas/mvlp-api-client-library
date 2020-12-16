using System;
using System.Collections.Generic;
using System.Text;

namespace MvLpApi.ClientLibrary.ApiModels
{
    public class GroupsApiResponse
    {
        public string ApiVersion { get; set; }
        public GroupsData Data { get; set; }
        public ApiError Error { get; set; }
    }
}
