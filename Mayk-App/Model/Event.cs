using SQLite;


namespace Mayk_App.Model
{
    [Table("event")]
    public class Event
    {
        [PrimaryKey, AutoIncrement]
        [Column("event_id")]
        public int EventId { get; set; }

        [NotNull]
        [Column("date")]
        public DateTime Date { get; set; }

        [NotNull]
        [Column("location")]
        public string Location { get; set; }

        [NotNull]
        [Column("description")]
        public string Description { get; set; }




        public Event()
        { }

        public Event(int eventId, DateTime date, string location, string description )
        {
            EventId = eventId;
            Date = date;
            Location = location;
            Description = description;
        }
    }
}
