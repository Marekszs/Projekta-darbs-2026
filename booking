public class Booking
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int EventId { get; set; }
    public Event Event { get; set; }

    [Range(1, 20)]
    public int TicketCount { get; set; }

    public DateTime BookingDate { get; set; } = DateTime.UtcNow;
}
