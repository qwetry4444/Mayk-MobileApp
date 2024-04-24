using SQLite;

namespace Mayk_App.Model
{
    [Table("user_repetition")]
    public class UserRepetition
    {
        public UserRepetition() { }

        public UserRepetition(int userRepetitionId, int usereId, int repetitionId)
        {
            UserRepetitionId = userRepetitionId;
            UsereId = usereId;
            RepetitionId = repetitionId;
        }

        [PrimaryKey, AutoIncrement]
        [Column("user_repetition_id")]
        public int UserRepetitionId { get; set; }

        [Indexed]
        [NotNull]
        [Column("user_id")]
        public int UsereId { get; set; }

        [Indexed]
        [NotNull]
        [Column("repetition_id")]
        public int RepetitionId { get; set; }
    }
}

