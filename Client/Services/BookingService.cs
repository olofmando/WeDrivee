using System.Net.Http.Json;
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
    }
}
