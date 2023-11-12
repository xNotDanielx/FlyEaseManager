using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using RestSharp;

namespace DAL
{
    public class ApiClient : IServiceClient
    {
        private readonly RestClient client;
        private readonly string baseURI;
        private readonly string authToken;

        public ApiClient(string baseURI, string authToken)
        {
            client = new RestClient(baseURI);
            this.baseURI = baseURI;
            this.authToken = authToken;
        }

        private void AddAuthorizationHeader(RestRequest request)
        {
            if (!string.IsNullOrEmpty(authToken))
            {
                request.AddHeader("Authorization", $"Bearer {authToken}");
            }
        }

        public async Task<string> GetAsync(string endpoint)
        {
            try
            {
                var request = new RestRequest(endpoint, Method.Get);
                AddAuthorizationHeader(request);
                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    return response.Content;
                }
                else
                {
                    return "Error en la solicitud Get";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> PostAsync(string endpoint, object data)
        {
            try
            {
                var request = new RestRequest(endpoint, Method.Post);
                AddAuthorizationHeader(request);
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(data);

                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    return response.Content;
                }
                else
                {
                    return "Error en la solicitud Post";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> PutAsync(string endpoint, object data) 
        {
            try
            {
                var request = new RestRequest(endpoint, Method.Put); // Puede ser Patch
                AddAuthorizationHeader(request);
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(data);

                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    return response.Content;
                }
                else
                {
                    return "Error en la solicitud Put";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> DeleteAsync(string endpoint)
        {
            try
            {
                var request = new RestRequest(endpoint, Method.Delete);
                AddAuthorizationHeader(request);
                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    return response.Content;
                }
                else
                {
                    return "Error en la solicitud Delete";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
