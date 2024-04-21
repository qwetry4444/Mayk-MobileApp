using SQLite;


namespace Mayk_App.Model
{
    [Table("repetitions")]
    public class Repetition
    {
        [PrimaryKey, AutoIncrement]
        [Column("repetition_id")]
        public int RepetitionId { get; set; }

        [NotNull]
        [Column("date")]
        public DateTime Date { get; set; }

        [NotNull]
        [Column("location")]
        public string Location { get; set; }

        [Indexed]
        [NotNull]
        [Column("event_id")]
        public string EventId { get; set; }




        public Repetition()
        { }

        public Repetition(int repetitionId, DateTime date, string location, string eventId)
        {
            RepetitionId = repetitionId;
            Date = date;
            Location = location;
            EventId = eventId;
        }
    }
}
