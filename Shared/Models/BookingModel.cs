namespace WeDrivee.Server.Models
{
    public class BookingModel
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string? UserToken { get; set; }

        // Relations
        public int CarId { get; set; }
        public CarModel? Car { get; set; }
    }
}
