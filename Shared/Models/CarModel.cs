namespace WeDrivee.Server.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public ICollection<BookingModel> Bookings { get; set; }
        public int DailyPrice { get; set; }
    }
}
