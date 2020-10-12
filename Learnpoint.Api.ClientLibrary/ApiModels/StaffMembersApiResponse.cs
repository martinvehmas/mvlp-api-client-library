namespace Learnpoint.Api.ClientLibrary.ApiModels
{
    public class StaffMembersApiResponse
    {
        public string ApiVersion { get; set; }
        public StaffMembersData Data { get; set; }
        public ApiError Error { get; set; }
    }
}
