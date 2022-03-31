using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Whyne.Models;

namespace Whyne.App
{
    public class ApiClient
    {
        private HttpClient _httpClient;

        public ApiClient(string baseUrl)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(baseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<User> Login(Credentials credentials)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("Auth/Login/", credentials);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                User mappedContent = JsonSerializer.Deserialize<User>(content);
                return mappedContent;
            }

            return default;
        }

        public async Task<T> Get<T>(string endPoint)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(endPoint);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                T mappedContent = JsonSerializer.Deserialize<T>(content);
                return mappedContent;
            }

            return default(T);
        }

        public async Task<T> Post<T>(string endPoint, T data)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(endPoint, data);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                T mappedContent = JsonSerializer.Deserialize<T>(content);
                return mappedContent;
            }

            return default(T);
        }

        public async Task<T> Put<T>(string endPoint, T data)
        {
            StringContent body = new(JsonSerializer.Serialize(data));
            HttpResponseMessage response = await _httpClient.PostAsync(endPoint, body);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                T mappedContent = JsonSerializer.Deserialize<T>(content);
                return mappedContent;
            }

            return default(T);
        }

        public async Task<T> Delete<T>(string endPoint, T data)
        {
            StringContent body = new(JsonSerializer.Serialize(data));
            HttpResponseMessage response = await _httpClient.PostAsync(endPoint, body);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                T mappedContent = JsonSerializer.Deserialize<T>(content);
                return mappedContent;
            }

            return default(T);
        }
    }
}