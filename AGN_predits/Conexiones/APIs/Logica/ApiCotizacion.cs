using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TheParfum.APIs.Logicas {
    internal class ApiCotizacion : IDisposable {
        private readonly HttpClient _httpClient;

        public ApiCotizacion(string baseUrl) {
            _httpClient = new HttpClient {
                BaseAddress = new Uri(baseUrl)
            };
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // Método GET: Realiza una solicitud GET y devuelve la respuesta como string.
        public async Task<string> GetAsync(string endpoint) {
            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode(); // Lanza una excepción si falla
            return await response.Content.ReadAsStringAsync();
        }
        // Método POST: Envía datos JSON al endpoint y devuelve la respuesta como string
        public async Task<string> PostAsync(string endpoint, string jsonData) {
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        // Método PUT: Actualiza datos en el servidor
        public async Task<string> PutAsync(string endpoint, string jsonData) {
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(endpoint, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
            //daw
        }
        // Método DELETE: Elimina datos en el servidor.
        public async Task<string> DeleteAsync(string endpoint) {
            var response = await _httpClient.DeleteAsync(endpoint);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        // Liberar recursos
        public void Dispose() {
            _httpClient.Dispose();
        }
    }
}