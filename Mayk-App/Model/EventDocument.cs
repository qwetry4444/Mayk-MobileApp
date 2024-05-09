using SQLite;

namespace Mayk_App.Model
{
    [Table("event_document")]
    public class EventDocument
    {
        [PrimaryKey, AutoIncrement]
        [Column("document_event_id")]
        public int DocumentEventId { get; set; }


        [Indexed]
        [NotNull]
        [Column("document_id")]
        public int DocumentId { get; set; }

        [Indexed]
        [NotNull]
        [Column("event_id")]
        public int EventId { get; set; }
    }
}

