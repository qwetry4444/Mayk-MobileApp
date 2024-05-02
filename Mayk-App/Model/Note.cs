using SQLite;

namespace Mayk_App.Model
{
    [Table("notes")]
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        [Column("note_id")]
        public int NoteId { get; set; }

        [Indexed]
        [NotNull]
        [Column("user_id")]
        public int UserId { get; set; }

        [Indexed]
        [NotNull]
        [Column("event_id")]
        public int EventId { get; set; }

        [NotNull]
        [Column("date")]
        public DateTime Date { get; set; }

        [NotNull]
        [Column("title")]
        public string Title { get; set; }


        [NotNull]
        [Column("description")]
        public string Description { get; set; }
    }
}
