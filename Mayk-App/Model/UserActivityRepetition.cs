using SQLite;


namespace Mayk_App.Model
{
    [Table("users_activities_repetitions")]
    public class UserActivityRepetition
    {
        [PrimaryKey, AutoIncrement]
        [Column("user_activity_repetition_id")]
        public int UserActivityRepetitionId { get; set; }

        [Indexed]
        [NotNull]
        [Column("user_activitie_id")]
        public int UserActivitieId { get; set; }

        [Indexed]
        [NotNull]
        [Column("repetition_id")]
        public int RepetitionId { get; set; }


        public UserActivityRepetition()
        { }

        public UserActivityRepetition(int userActivityRepetitionsId, int userActivitieId, int repetitionId)
        {
            UserActivityRepetitionsId = userActivityRepetitionsId;
            UserActivitieId = userActivitieId;
            RepetitionId = repetitionId;
        }
    }
}
