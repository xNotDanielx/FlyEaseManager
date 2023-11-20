using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entity.Utilidades;
using Newtonsoft.Json;
using RestSharp;

namespace DAL
{
    public class ApiClient : IServiceClient
    {
        private readonly RestClient client;
        private readonly string baseURI;
        private string authToken;
        private string refreshToken;

        public ApiClient(string baseURI, string authToken, string refreshToken)
        {
            client = new RestClient(baseURI);
            this.baseURI = baseURI;
            this.authToken = authToken;
            this.refreshToken = refreshToken;
        }

        private void AddAuthorizationHeader(RestRequest request)
        {
            if (!string.IsNullOrEmpty(authToken))
            {
                request.AddHeader("Authorization", $"Bearer {authToken}");
            }
        }

        private async Task<bool> RefreshToken()
        {
            string endpoint = "https://flyeasewebapi.azurewebsites.net/FlyEaseApi/Administradores/GetRefreshToken";

            var request = new RestRequest(endpoint, Method.Post);
            request.RequestFormat = DataFormat.Json;

            var refreshTokenRequest = new
            {
                expiredToken = authToken,
                refreshToken = refreshToken
            };

            request.AddJsonBody(refreshTokenRequest);
            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                string jsonResponse = response.Content;
                var responseObject = JsonConvert.DeserializeObject<RespuestaAutenticacion>(jsonResponse);

                authToken = responseObject?.Response?.Token?.TokenString;
                refreshToken = responseObject?.Response?.Token?.RefreshToken;

                TokenManager._instance._token = authToken;
                TokenManager._instance._refresh = refreshToken;

                return true;
            }
            else
            {
                return false;
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
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    var refresh = await RefreshToken();
                    if (refresh)
                    {
                        var res = await GetAsync(endpoint);
                        return res;
                    }
                    return "Error en la solicitud Get";
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
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    var refresh = await RefreshToken();
                    if (refresh)
                    {
                        var res = await PostAsync(endpoint, data);
                        return res;
                    }
                    return "Error en la solicitud Post";
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
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    var refresh = await RefreshToken();
                    if (refresh)
                    {
                        var res = await PutAsync(endpoint, data);
                        return res;
                    }
                    return "Error en la solicitud Post";
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
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    var refresh = await RefreshToken();
                    if (refresh)
                    {
                        var res = await DeleteAsync(endpoint);
                        return res;
                    }
                    return "Error en la solicitud Post";
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
