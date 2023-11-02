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

        public ApiClient(string baseURI)
        {
            client = new RestClient(baseURI);
            this.baseURI = baseURI;
        }

        public async Task<string> GetAsync(string endpoint)
        {
            try
            {
                var request = new RestRequest(endpoint, Method.Get);
                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    return response.Content;
                }
                else
                {
                    return $"Error en la solicitud Get: {response.ErrorMessage}";
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
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(data);

                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    return response.Content;
                }
                else
                {
                    return $"Error en la solicitud Post: {response.ErrorMessage}";
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
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(data);

                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    return response.Content;
                }
                else
                {
                    return $"Error en la solicitud Put: {response.ErrorMessage}";
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
                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    return response.Content;
                }
                else
                {
                    return $"Error en la solicitud Delete: {response.ErrorMessage}";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
