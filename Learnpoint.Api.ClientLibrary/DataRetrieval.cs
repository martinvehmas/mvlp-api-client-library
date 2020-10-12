using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Learnpoint.Api.ClientLibrary
{
    public static class DataRetrieval
    {
        public const string ApiVersion = "v2";
        public enum Endpoint
        {
            Students,
            Groups,
            StaffMembers
        }
        public static ApiModels.StudentsData GetStudentsData(string studentsJSONData)
        {
            var response = JsonSerializer.Deserialize<ApiModels.StudentsApiResponse>(studentsJSONData);
            if (response.Error != null)
            {
                throw new ApplicationException(string.Format("Error returned from service: '{0}'", response.Error.Message));
            }
            else
            {
                return response.Data;
            }
        }
        public static ApiModels.GroupsData GetGroupsData(string groupsJSONData)
        {
            var response = JsonSerializer.Deserialize<ApiModels.GroupsApiResponse>(groupsJSONData);
            if (response.Error != null)
            {
                throw new ApplicationException(string.Format("Error returned from service: '{0}'", response.Error.Message));
            }
            else
            {
                return response.Data;
            }
        }
        public static ApiModels.StaffMembersData GetStaffMembersData(string staffMembersJSONData)
        {
            var response = JsonSerializer.Deserialize<ApiModels.StaffMembersApiResponse>(staffMembersJSONData);
            if (response.Error != null)
            {
                throw new ApplicationException(string.Format("Error returned from service: '{0}'", response.Error.Message));
            }
            else
            {
                return response.Data;
            }
        }
        public static string GetAccessToken(string tokenEndpointUri, string clientId, string clientSecret, string requestedScopes)
        {
            var tokenHttpClient = new HttpClient();

            var credentials = String.Format("{0}:{1}",
                                            clientId,
                                            clientSecret);
            var base64Credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials));

            tokenHttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", base64Credentials);

            var tokenResponse = tokenHttpClient.PostAsync(tokenEndpointUri,
                                                            new FormUrlEncodedContent(new Dictionary<string, string>{
                                                                { "grant_type", "client_credentials" },
                                                                { "scope", requestedScopes }
                                                                })).Result;

            var tokenResponseContent = tokenResponse.Content.ReadAsStringAsync().Result;

            //Construct a JSON document from the response and extract the AccessToken
            var tokenResponseJSON = JsonDocument.Parse(tokenResponseContent);
            string accessToken = null;
            if (tokenResponseJSON.RootElement.TryGetProperty("access_token", out JsonElement accessTokenJSONValue))
            {
                accessToken = accessTokenJSONValue.ToString();
            }
            return accessToken;
        }
        public static string GetApiJSONDataString(string baseAddress, string tenantIdentifier, Endpoint endpoint, string accessToken, int? dataScopeRootGroupId = null)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseAddress)
            };
            
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

            var parameterString = dataScopeRootGroupId.HasValue ? $"?datascoperootgroupid={dataScopeRootGroupId}" : "";
            var path = $"/bulkapi/{ApiVersion.ToLower()}/{tenantIdentifier}/{endpoint}{parameterString}";
            var response = client.GetStringAsync(path).Result;
            return response;
        }
    }
}
