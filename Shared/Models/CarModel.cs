namespace WeDrivee.Server.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DailyPrice { get; set; }

        public List<BookingModel> Bookings { get; set; }
    }
}
