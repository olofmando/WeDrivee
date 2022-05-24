using System.Net.Http.Json;
using WeDrivee.Server.Models;

namespace WeDrivee.Client.Services
{
    public class CarService
    {
        private readonly HttpClient _httpClient;
        public CarService(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task<List<CarModel>> GetCars()
        {
           return await _httpClient.GetFromJsonAsync<List<CarModel>>("api/car/");
        }
    }
}
