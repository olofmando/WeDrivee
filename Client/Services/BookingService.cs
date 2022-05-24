using System.Net.Http.Json;
using WeDrivee.Server.Models;
using WeDrivee.Shared;

namespace WeDrivee.Client.Services
{
    public class BookingService
    {
        private readonly HttpClient _httpClient;
        public BookingService(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task PostBook(BookingDto bookingDto)
        {
            await _httpClient.PostAsJsonAsync("api/booking/confirm", bookingDto);
        }

        public async Task<List<BookingModel>> Get(string username)
        {
            return await _httpClient.GetFromJsonAsync<List<BookingModel>>("api/booking/"+username);
        }

        public async Task <List<BookingModel>> Get()
        {
            return await _httpClient.GetFromJsonAsync<List<BookingModel>>("api/booking");
        }
        
        public async Task Unbook(UnbookDto unbookDto)
        {
            await _httpClient.PutAsJsonAsync("api/booking/unbook", unbookDto);
        }

    }
}
