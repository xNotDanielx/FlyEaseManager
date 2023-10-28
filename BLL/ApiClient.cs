using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace BLL
{
    public class ApiClient
    {
        private readonly RestClient client;
        private readonly string URIbase;

        public ApiClient(string URIbase)
        {
            client = new RestClient(URIbase);
            this.URIbase = URIbase;
        }

        public async Task<string> GetAsync(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Get);
            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                throw new Exception($"Error en la solicitud: {response.ErrorMessage}");
            }
        }

        public async Task<string> PostAsync(string endpoint, object data)
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
                throw new Exception($"Error en la solicitud: {response.ErrorMessage}");
            }
        }

        public async Task<string> PutAsync(string endpoint, object data) 
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
                throw new Exception($"Error en la solicitud: {response.ErrorMessage}");
            }
        }

        public async Task<string> DeleteAsync(string endpoint)
        {
            var request = new RestRequest(endpoint);

            RestResponse response = await client.ExecuteAsync(request);

            if(response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                throw new Exception($"Error en la solicitud: {response.ErrorMessage}");
            }
        }

    }
}
