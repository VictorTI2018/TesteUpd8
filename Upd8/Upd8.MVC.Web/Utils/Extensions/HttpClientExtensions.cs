using System.Net.Http.Headers;
using System.Text.Json;

namespace Upd8.MVC.Web.Utils.Extensions
{
    public static class HttpClientExtensions
    {
        private static MediaTypeHeaderValue _mediaType = new MediaTypeHeaderValue("application/json");
        public static async Task<T> ReadAsJsonAsync<T>(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode) 
                throw new ApplicationException($"Ocorreu um erro na chamada da API: {response.ReasonPhrase}");

            var dataAsString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(dataAsString, new JsonSerializerOptions{ PropertyNameCaseInsensitive = true });
        }

        public static async Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient httpClient, string url, T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = _mediaType;
            return await httpClient.PostAsync(url, content);
        }

        public static async Task<HttpResponseMessage> PutAsJsonAsync<T>(this HttpClient httpClient, string url, T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = _mediaType;
            return await httpClient.PutAsync(url, content);
        }
    }
}
