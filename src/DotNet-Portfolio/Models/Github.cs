using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DotNet_Portfolio.Models.EnvironmentVariables;

namespace DotNet_Portfolio.Models
{
    public class Github
    {
        public static JObject TestGitAPI()
        {
            var client = new RestClient("https://api.github.com");
            var request = new RestRequest(Method.GET);
            request.AddHeader("User-Agent", EnviroVar.UserName);
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
            return jsonResponse;
        }

        public static JArray GetGitRepos()
        {
            var client = new RestClient("https://api.github.com");
            var request = new RestRequest("users/"+ EnviroVar.UserName + "/repos", Method.GET);
            request.AddHeader("User-Agent", EnviroVar.UserName);
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            return jsonResponse;
        }

        public static JObject GetStarredRepos()
        {
            var client = new RestClient("https://api.github.com");
            var request = new RestRequest("/search/repositories?q=user:" + EnviroVar.UserName + "&sort=stars&order=desc", Method.GET);
            request.AddHeader("User-Agent", EnviroVar.UserName);
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
            return jsonResponse;
        }

        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response =>
            {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }
    }
}
