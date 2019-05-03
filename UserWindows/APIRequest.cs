using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserWindows
{
    public class APIRequest
    {
        public static dynamic GetDynamicResponse(string query, Method method = Method.GET, object obj = null)
        {
            dynamic dynamicResponse;
            RestClient client = null;
            client = new RestClient($"http://localhost:49943/api/{query}");
            var request = new RestRequest(method);
            switch (method)
            {
                case Method.GET:
                    break;
                case Method.POST:
                    if (obj != null)
                    {
                        if (obj.GetType() == typeof(string))
                        {
                            request.AddParameter("undefined", obj, ParameterType.RequestBody);
                        }
                        else
                        {
                            request.AddJsonBody(obj);
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                case Method.PUT:
                    break;
                case Method.DELETE:
                    if (obj != null)
                    {
                        request.AddJsonBody(obj);
                    }
                    else
                    {
                        return null;
                    }
                    break;
                case Method.HEAD:
                    break;
                case Method.OPTIONS:
                    break;
                case Method.PATCH:
                    break;
                case Method.MERGE:
                    break;
                case Method.COPY:
                    break;
                default:
                    break;
            }
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                dynamicResponse = Newtonsoft.Json.Linq.JObject.Parse(response.Content);
            }
            else
            {
                dynamicResponse = null;
            }
            return dynamicResponse;
        }

    }
}
