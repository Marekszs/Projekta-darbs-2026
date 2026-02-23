public class Event
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime Date { get; set; }

    [Range(0, 10000)]
    public decimal Price { get; set; }

    public List<Booking>? Bookings { get; set; }
}
